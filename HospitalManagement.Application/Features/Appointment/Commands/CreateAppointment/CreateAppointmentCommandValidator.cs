using FluentValidation;
using HospitalManagement.Application.Extensions.Validation;

namespace HospitalManagement.Application.Features.Appointment;

public class CreateAppointmentCommandValidator : AbstractValidator<CreateAppointmentCommand>
{
    public CreateAppointmentCommandValidator()
    {
        RuleFor(member => member.PatientId.ToString())
            .NotEmpty()
            .IsGuid().WithMessage("Invalid patientId format");

        RuleFor(member => member.DoctorId.ToString())
            .NotEmpty()
            .IsGuid().WithMessage("Invalid doctorId format");

        RuleFor(member => member.AppointmentDate)
            .NotNull().NotEmpty()
            .GreaterThan(DateTime.Now).WithMessage("Appointment date must be greater than the current date");
    }
}
