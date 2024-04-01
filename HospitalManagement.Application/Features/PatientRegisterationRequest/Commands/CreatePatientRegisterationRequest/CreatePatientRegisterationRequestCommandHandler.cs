using HospitalManagement.Application.Contracts;
using HospitalManagement.Application.Contracts.EmailService;
using HospitalManagement.Application.Contracts.Logging;
using HospitalManagement.Application.Contracts.Persistence;
using HospitalManagement.Application.Exceptions;
using HospitalManagement.Application.Models.AccessCodeService;
using HospitalManagement.Application.Models.EmailService;
using MediatR;
using Microsoft.Extensions.Options;

namespace HospitalManagement.Application.Features.PatientRegisterationRequest;

public class CreatePatientRegisterationRequestCommandHandler : IRequestHandler<CreatePatientRegisterationRequestCommand, Unit>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IAccessCodeService _accessCodeService;
    private readonly IEmailSender _emailSender;
    private readonly AccessCodeSettings _accessCodeSettings;
    private readonly FrontendSettings _frontendSettings;
    private readonly IAppLogger<CreatePatientRegisterationRequestCommandHandler> _logger;

    public CreatePatientRegisterationRequestCommandHandler(
        IUnitOfWork unitOfWork,
        IAccessCodeService accessCodeService,
        IEmailSender emailSender,
        IOptions<AccessCodeSettings> accessCodeOptions,
        IOptions<FrontendSettings> frontendSettingsOptions,
        IAppLogger<CreatePatientRegisterationRequestCommandHandler> logger)
    {
        _unitOfWork = unitOfWork;
        _accessCodeService = accessCodeService;
        _emailSender = emailSender;
        _accessCodeSettings = accessCodeOptions.Value;
        _frontendSettings = frontendSettingsOptions.Value;
        _logger = logger;
    }

    public async Task<Unit> Handle(CreatePatientRegisterationRequestCommand request, CancellationToken cancellationToken)
    {
        var validator = new CreatePatientRegisterationRequestCommandValidator(_unitOfWork);
        var validationResult = await validator.ValidateAsync(request, cancellationToken);
        if(validationResult.Errors.Any())
        {
            throw new BadRequestException($"{nameof(Domain.Entities.PatientRegisterationRequest)} throws validation errors", validationResult);
        }
        var accessCode = _accessCodeService.GenerateAccessCode();
        var patientRegisterationRequest = new Domain.Entities.PatientRegisterationRequest
        {
            Email = request.Email,
            AccessCode = accessCode,
            ExpiresOn = DateTime.UtcNow.AddHours(_accessCodeSettings.ExpirationDurationInHours),
        };
        var data = await _unitOfWork.PatientRegisterationRequestRepository.CreateAsync(patientRegisterationRequest);
        await _unitOfWork.CompleteAsync();
        var link = $"{_frontendSettings.Url}/signup/verify-email?requestId={data.Id}&access-code={accessCode}";
        var emailBody = "<div>"
            + "<h3>Hello</h3>"
            + "<p>Welcome to clinic one. Kindly click the link below to verify your email</p>"
            + "<a href=" + link + ">Verify Email </a><br/>"
            + "<p>If you have any difficulty clicking the link, copy and paste the link below in your browser</p>"
            + "<p>" + link + "</p>"
            + "</div>";
        var email = new Email(request.Email, "Verify Email", emailBody, null);
        var emailSent = await _emailSender.SendEmail(email);

        if(!emailSent)
        {
            _logger.LogWarning(
                $"Unable to send verification link for {nameof(CreatePatientRegisterationRequestCommandHandler)} " +
                $"with email {request.Email}", 
                request
            );
        }

        return Unit.Value;
    }
}
