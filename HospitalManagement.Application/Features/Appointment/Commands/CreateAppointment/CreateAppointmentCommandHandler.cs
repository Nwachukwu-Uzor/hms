using AutoMapper;
using HospitalManagement.Application.Contracts.EmailService;
using HospitalManagement.Application.Contracts.Persistence;
using HospitalManagement.Application.Exceptions;
using HospitalManagement.Application.Models.EmailService;
using MediatR;

namespace HospitalManagement.Application.Features.Appointment;

public class CreateAppointmentCommandHandler : IRequestHandler<CreateAppointmentCommand, Guid>
{
    private readonly IUnitOfWork _unitOfWork;
    private IEmailSender _emailSender;
    private readonly IMapper _mapper;
    public CreateAppointmentCommandHandler(IUnitOfWork unitOfWork, IEmailSender emailSender, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _emailSender = emailSender;
        _mapper = mapper;
    }

    public async Task<Guid> Handle(CreateAppointmentCommand request, CancellationToken cancellationToken)
    {
        var validator = new CreateAppointmentCommandValidator();
        var validationResult = validator.Validate(request);

        if (validationResult.Errors.Any())
        {
            throw new BadRequestException(nameof(Domain.Entities.Patient), validationResult);
        }

        var doctor = await _unitOfWork.DoctorRepository.GetByIdAsync(request.DoctorId);

        if (doctor is null)
        {
            throw new BadRequestException($"The doctor id provided {request.DoctorId} is invalid");
        }

        var patient = await _unitOfWork.PatientRepository.GetByIdWithAppUserAsync(request.PatientId);

        if (patient is null)
        {
            throw new BadRequestException($"The patient id provided {request.PatientId} is invalid");
        }

        // TODO: 
        // 1. Check if there are any conflicting appointments for doctor or patient
        // 2. Check if the doctor has exceeding the maximum appointment allowed for the day

        var appointmentEntity = _mapper.Map<Domain.Entities.Appointment>(request);
        await _unitOfWork.AppointmentRepository.CreateAsync(appointmentEntity);
        await _unitOfWork.CompleteAsync();
        var emailBody = "<div>" 
            + "<h3>Dear " + patient.FirstName + ", </h3>"
            + "<p>A new appointment has been create for you" 
            + " on " + request.AppointmentTime.ToShortDateString() + " by " + request.AppointmentTime.ToShortTimeString() + "</p>"
            + "<p>If you have any question kindly call <strong>+2348064879196</strong></p>"
            + "</div>";
        var email = new Email(patient.AppUser.Email, "Appointment Created Successfully", emailBody, null);
        await _emailSender.SendEmail(email);
        return appointmentEntity.Id;
    }
}
