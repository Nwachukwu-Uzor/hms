using FluentValidation;
using HospitalManagement.Application.Extensions.Validation;

namespace HospitalManagement.Application.Features.Appointment;

public class GetAppointmentsByPatientAppUserIdPaginatedQueryValidator 
: AbstractValidator<GetAppointmentsByPatientAppUserIdPaginatedQuery>
{
    public GetAppointmentsByPatientAppUserIdPaginatedQueryValidator()
    {
        RuleFor(member => member.PatientId.ToString())
            .NotEmpty().NotNull()
            .IsGuid().WithMessage("Invalid Patient Id");

        RuleFor(member => member.Page)
            .NotNull().NotEmpty()
            .GreaterThan(0);

        RuleFor(member => member.PageSize)
            .NotNull().NotEmpty()
            .GreaterThan(0);
    }
}
