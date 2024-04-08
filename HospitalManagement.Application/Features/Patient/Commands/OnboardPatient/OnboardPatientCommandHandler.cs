using AutoMapper;
using HospitalManagement.Application.Contracts.AuthService;
using HospitalManagement.Application.Contracts.EmailService;
using HospitalManagement.Application.Contracts.IDGenerator;
using HospitalManagement.Application.Contracts.Logging;
using HospitalManagement.Application.Contracts.Persistence;
using HospitalManagement.Application.Exceptions;
using HospitalManagement.Application.Features.PatientRegisterationRequest;
using HospitalManagement.Application.Models.AccessCodeService;
using HospitalManagement.Application.Models.AuthService;
using HospitalManagement.Application.Models.EmailService;
using MediatR;
using Microsoft.Extensions.Options;

namespace HospitalManagement.Application.Features.Patient;

public class OnboardPatientCommandHandler : IRequestHandler<OnboardPatientCommand, string>
{
    private readonly IRoleManager _roleManager;
    private readonly RolesId _rolesId;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IPasswordService _passwordService;
    private readonly IIDGenerator _idGenerator;
    private readonly IEmailSender _emailSender;
    private readonly IMapper _mapper;
    private readonly FrontendSettings _frontendSettings;
    private readonly IAppLogger<OnboardPatientCommandHandler> _logger;

    public OnboardPatientCommandHandler(
        IRoleManager roleManager,
        IOptions<RolesId> option,
        IUnitOfWork unitOfWork,
        IPasswordService passwordService,
        IIDGenerator idGenerator,
        IEmailSender emailSender,
        IMapper mapper,
        IAppLogger<OnboardPatientCommandHandler> logger,
        IOptions<FrontendSettings> frontendSettingsOptions
    )
    {
        _roleManager = roleManager;
        _rolesId = option.Value;
        _unitOfWork = unitOfWork;
        _passwordService = passwordService;
        _idGenerator = idGenerator;
        _emailSender = emailSender;
        _mapper = mapper;
        _logger = logger;
        _frontendSettings = frontendSettingsOptions.Value;
    }
    public async Task<string> Handle(OnboardPatientCommand request, CancellationToken cancellationToken)
    {
        var validator = new OnboardPatientCommandValidator(_unitOfWork);
        var validationResult = await validator.ValidateAsync(request, cancellationToken);
        if (validationResult.Errors.Any())
        {
            throw new BadRequestException($"{nameof(Domain.Entities.Patient)} returns validation errors", validationResult);
        }
        var password = _passwordService.GenerateRandomPassword();
        var passwordHash = _passwordService.HashPassword(password);
        var appUser = new Domain.Entities.AppUser()
        {
            Email = request.Email,
            Password = passwordHash.Hash,
            Salt = passwordHash.Salt
        };

        var appUserEntity = await _unitOfWork.AppUserRepository.CreateAsync(appUser);
        var patient = _mapper.Map<Domain.Entities.Patient>(request);
        patient.AppUser = appUserEntity;
        var patientId = await _idGenerator.GeneratePatientIDNumber();
        patient.PatientID = patientId;
        var response = await _unitOfWork.PatientRepository.CreateAsync(patient);
        await _unitOfWork.CompleteAsync();
        await _roleManager.AddUserToRole(appUserEntity.Id, _rolesId.PatientRoleId);
        await _unitOfWork.CompleteAsync();
        var link = $"{_frontendSettings.Url}/login";
        var emailBody = "<div>"
            + "<h3>Hello " + request.FirstName + " " + request.LastName + "</h3>"
            + "<p>Welcome to clinic one. You have been successfully onboarded on our patient platform. <br />" +
            "Your patient Id is " + patientId + ". Kindly, click on the link below to login.</p>"
            + "<a href=" + link + ">Login </a><br/>"
            + "<p>Your login credentials are <br />"
            + "Email: " + request.Email + "<br /> Password: " + password + "</p>"
            + "<p>Your are advised to change your password once you login.</p>"
            + "<p>If you have any difficulty clicking the link, copy and paste the link below in your browser</p>"
            + "<p>" + link + "</p>"
            + "</div>";
        var email = new Email(request.Email, "Onboarding Complete", emailBody, null);
        var emailSent = await _emailSender.SendEmail(email);

        if (!emailSent)
        {
            _logger.LogWarning(
                $"Unable to send verification link for {nameof(CreatePatientRegisterationRequestCommandHandler)} " +
                $"with email {request.Email}",
                request
            );
        }
        return patientId;
    }
}
