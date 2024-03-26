using FluentValidation;

namespace HospitalManagement.Application.Features.Staff.Commands.AddStaff;

public class AddStaffCommandValidator : AbstractValidator<AddStaffCommand>
{
    public AddStaffCommandValidator()
    {
        RuleFor(p => p.FirstName).NotEmpty()
            .MinimumLength(4).WithMessage("{PropertyName} must be at least 4 characters long");
        
        RuleFor(p => p.LastName).NotEmpty()
            .MinimumLength(4).WithMessage("{PropertyName} must be at least 4 characters long");
        
        RuleFor(p => p.Address).NotEmpty()
            .MinimumLength(4).WithMessage("{PropertyName} must be at least 4 characters long");

        RuleFor(p => p.DateOfBirth).NotEmpty()
            .NotNull().WithMessage("{PropertyName must not be empty}")
            .LessThanOrEqualTo(DateTime.Now);
        
        RuleFor(p => p.AppUserId).NotEmpty()
            .NotNull().WithMessage("{PropertyName must not be empty}"); 
        
        RuleFor(p => p.JobId).NotEmpty()
            .NotNull().WithMessage("{PropertyName must not be empty}");      
    }
}
