using HospitalManagement.Application.Contracts;
using HospitalManagement.Application.Contracts.EmailService;
using HospitalManagement.Application.Contracts.Persistence;
using HospitalManagement.Application.Exceptions;
using MediatR;

namespace HospitalManagement.Application.Features.PatientRegisterationRequest;

public class CreatePatientRegisterationRequestCommandHandler : IRequestHandler<CreatePatientRegisterationRequestCommand, Unit>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IAccessCodeService _accessCodeService;
    private readonly IEmailSender _emailSender;

    public CreatePatientRegisterationRequestCommandHandler(
        IUnitOfWork unitOfWork,
        IAccessCodeService accessCodeService,
        IEmailSender emailSender)
    {
        _unitOfWork = unitOfWork;
        _accessCodeService = accessCodeService;
        _emailSender = emailSender;
    }

    public async Task<Unit> Handle(CreatePatientRegisterationRequestCommand request, CancellationToken cancellationToken)
    {
        var validator = new CreatePatientRegisterationRequestCommandValidator(_unitOfWork);
        var validationResult = await validator.ValidateAsync(request);
        if(validationResult.Errors.Any())
        {
            throw new BadRequestException(
                $"{nameof(Domain.Entities.PatientRegisterationRequest)} throws validation errors",
                validationResult
            );
        }
        throw new NotImplementedException();
    }
}
