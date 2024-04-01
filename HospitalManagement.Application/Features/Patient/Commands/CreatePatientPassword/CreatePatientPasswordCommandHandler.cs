using HospitalManagement.Application.Contracts.AuthService;
using HospitalManagement.Application.Contracts.EmailService;
using HospitalManagement.Application.Contracts.Logging;
using HospitalManagement.Application.Contracts.Persistence;
using HospitalManagement.Application.Exceptions;
using HospitalManagement.Application.Models.AuthService;
using HospitalManagement.Application.Models.EmailService;
using MediatR;
using Microsoft.Extensions.Options;

namespace HospitalManagement.Application.Features.Patient;

public class CreatePatientPasswordCommandHandler : IRequestHandler<CreatePatientPasswordCommand, Guid>
{
    private readonly IPasswordService _passwordManager;
    private readonly IRoleManager _roleManager;
    private readonly RolesId _rolesId;
    private readonly IUnitOfWork _unitOfWork; 
    private readonly IEmailSender _emailSender;
    private readonly IAppLogger<CreatePatientPasswordCommandHandler> _logger;

    public CreatePatientPasswordCommandHandler(
        IPasswordService passwordManager,
        IRoleManager roleManager,
        IOptions<RolesId> option,
        IUnitOfWork unitOfWork,
        IEmailSender emailSender,
        IAppLogger<CreatePatientPasswordCommandHandler> logger
    )
    {
        _passwordManager = passwordManager;
        _roleManager = roleManager;
        _rolesId = option.Value;
        _unitOfWork = unitOfWork;
        _emailSender = emailSender;
        _logger = logger;
    }
    public async Task<Guid> Handle(CreatePatientPasswordCommand request, CancellationToken cancellationToken)
    {
        var validator = new CreatePatientPasswordCommandValidator();

        var validationResult = validator.Validate(request);
        if (validationResult.Errors.Any())
        {
            throw new BadRequestException($"{nameof(Domain.Entities.AppUser)} returns validation errors", validationResult);
        }

        var patientRegisterationRequest = await _unitOfWork.PatientRegisterationRequestRepository.GetByIdAsync(request.PatientRegisterationRequestId);

        if (patientRegisterationRequest is null || patientRegisterationRequest.VerificationStatus != Domain.Enums.PatientRequestVerificationStatus.VERIFIED)
        {
            throw new BadRequestException("Invalid patient registeration request Id");
        }

        if (patientRegisterationRequest.VerificationStatus == Domain.Enums.PatientRequestVerificationStatus.COMPLETED)
        {
            throw new BadRequestException("The patient has already been registered");
        }

        var isEmailUnique = await _unitOfWork.AppUserRepository.IsEmailUnique(patientRegisterationRequest.Email);

        if (!isEmailUnique)
        {
            throw new BadRequestException("The patient has already been registered");
        }

        var passwordHash = _passwordManager.HashPassword(request.Password);
        var appUser = new Domain.Entities.AppUser()
        {
            Email = patientRegisterationRequest.Email,
            Password = passwordHash.Hash,
            Salt = passwordHash.Salt
        };
        var user = await _unitOfWork.AppUserRepository.CreateAsync(appUser);
        await _unitOfWork.CompleteAsync();
        patientRegisterationRequest.VerificationStatus = Domain.Enums.PatientRequestVerificationStatus.COMPLETED;
        _unitOfWork.PatientRegisterationRequestRepository.UpdateAsync(patientRegisterationRequest);
        await _roleManager.AddUserToRole(appUser.Id, _rolesId.PatientRoleId);
        var welcomeEmailBody = "<div>" +
            "<h3>Hello, </h3>" +
            "<p>Welcome to clinic, we are glad you choose us.</p>" +
            "</div>";

        var welcomeEmail = new Email(patientRegisterationRequest.Email, "Welcome to Clinic One", welcomeEmailBody, null);

        var isEmailSent = await _emailSender.SendEmail(welcomeEmail);
        if (!isEmailSent)
        {
            _logger.LogWarning($"Unable to send email for patient user creating request with email ${patientRegisterationRequest.Email}");
        }
        return user.Id;
    }
}
