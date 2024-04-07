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
using HospitalManagement.Domain.Entities;
using MediatR;
using Microsoft.Extensions.Options;

namespace HospitalManagement.Application.Features.Staff;

public class OnboardStaffCommandHandler : IRequestHandler<OnboardStaffCommand, string>
{
    private readonly IRoleManager _roleManager;
    private readonly RolesId _rolesId;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IPasswordService _passwordService;
    private readonly IIDGenerator _idGenerator;
    private readonly IEmailSender _emailSender;
    private readonly IMapper _mapper;
    private readonly FrontendSettings _frontendSettings;
    private readonly IAppLogger<OnboardStaffCommandHandler> _logger;

    public OnboardStaffCommandHandler(
        IRoleManager roleManager,
        IOptions<RolesId> option,
        IUnitOfWork unitOfWork,
        IPasswordService passwordService,
        IIDGenerator idGenerator,
        IEmailSender emailSender,
        IMapper mapper,
        IAppLogger<OnboardStaffCommandHandler> logger,
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
    public async Task<string> Handle(OnboardStaffCommand request, CancellationToken cancellationToken)
    {
        var validator = new OnboardStaffCommandValidator(_unitOfWork);
        var validationResult = await validator.ValidateAsync(request, cancellationToken);
        if (validationResult.Errors.Any())
        {
            throw new BadRequestException($"{nameof(Domain.Entities.Staff)} returns validation errors", validationResult);
        }
        var password = _passwordService.GenerateRandomPassword();
        var passwordHash = _passwordService.HashPassword(password);
        var appUser = new Domain.Entities.AppUser()
        {
            Email = request.Email,
            Password = passwordHash.Hash,
            Salt = passwordHash.Salt
        };
        var job = await _unitOfWork.JobRepository.GetByIdAsync(request.JobId);

        if (job == null)
        {
            throw new NotFoundException(nameof(Domain.Entities.Job), request.JobId);
        }

        var appUserEntity = await _unitOfWork.AppUserRepository.CreateAsync(appUser);
        var staff = _mapper.Map<Domain.Entities.Staff>(request);
        staff.Job = job;
        staff.AppUser = appUserEntity;
        var staffId = await _idGenerator.GenerateStaffIDNumber();
        staff.StaffID = staffId;
        var response = await _unitOfWork.StaffRepository.CreateAsync(staff);
        await _unitOfWork.CompleteAsync();
        await _roleManager.AddUserToRole(appUserEntity.Id, _rolesId.StaffRoleId);
        var isJobADoctor = await _unitOfWork.DoctorJobRepository.IsJobIdADocter(request.JobId);
        if (isJobADoctor)
        {
            var doctorEntity = new Domain.Entities.Doctor
            {
                StaffId = staff.Id
            };
            await _unitOfWork.DoctorRepository.CreateAsync(doctorEntity);
        }
        await _unitOfWork.CompleteAsync();
        var link = $"{_frontendSettings.Url}/staff/login";
        var emailBody = "<div>"
            + "<h3>Hello " + request.FirstName + " " + request.LastName + "</h3>"
            + "<p>Welcome to clinic one. You have been successfully onboarded on how staff platform. <br />" +
            "Your staff Id is " + staffId + ". Kindly, click on the link below to login.</p>"
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
        return staffId;
    }
}
