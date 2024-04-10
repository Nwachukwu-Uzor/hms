using FluentValidation;

namespace HospitalManagement.Application.Features.Appointment;

public class GetAppointmentsByPatientIdPaginatedQueryValidator : AbstractValidator<GetAppointmentsByPatientIdPaginatedQuery>
{
    public GetAppointmentsByPatientIdPaginatedQueryValidator()
    {
        RuleFor(member => member.PatientId)
            .NotEmpty().NotNull();

        RuleFor(member => member.Page)
            .NotNull().NotEmpty()
            .GreaterThan(0);

        RuleFor(member => member.PageSize)
            .NotNull().NotEmpty()
            .GreaterThan(0);
    }
}
