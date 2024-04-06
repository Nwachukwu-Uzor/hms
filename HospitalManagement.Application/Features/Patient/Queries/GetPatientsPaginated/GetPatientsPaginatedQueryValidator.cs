using FluentValidation;

namespace HospitalManagement.Application.Features.Patient;

public class GetPatientsPaginatedQueryValidator : AbstractValidator<GetPatientsPaginatedQuery>
{
    public GetPatientsPaginatedQueryValidator()
    {
        RuleFor(member => member.Page)
            .NotNull().NotEmpty()
            .GreaterThan(0);

        RuleFor(member => member.PageSize)
            .NotNull().NotEmpty()
            .GreaterThan(0);
    }
}
