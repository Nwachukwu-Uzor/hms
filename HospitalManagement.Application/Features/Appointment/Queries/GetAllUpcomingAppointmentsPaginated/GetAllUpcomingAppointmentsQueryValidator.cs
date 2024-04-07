using FluentValidation;

namespace HospitalManagement.Application.Features.Appointment;

public class GetAllUpcomingAppointmentsQueryValidator : AbstractValidator<GetAllUpcomingAppointmentsPaginatedQuery>
{
    public GetAllUpcomingAppointmentsQueryValidator()
    {
        RuleFor(member => member.Page)
            .NotNull().NotEmpty()
            .GreaterThan(0);

        RuleFor(member => member.PageSize)
            .NotNull().NotEmpty()
            .GreaterThan(0);
    }
}
