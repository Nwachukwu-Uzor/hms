using FluentValidation;

namespace HospitalManagement.Application.Features.Staff;

public class GetStaffPaginatedQueryValidator : AbstractValidator<GetStaffPaginatedQuery>
{
    public GetStaffPaginatedQueryValidator()
    {
        RuleFor(member => member.Page)
            .NotNull().NotEmpty()
            .GreaterThan(0); 
        
        RuleFor(member => member.PageSize)
            .NotNull().NotEmpty()
            .GreaterThan(0);
    }
}
