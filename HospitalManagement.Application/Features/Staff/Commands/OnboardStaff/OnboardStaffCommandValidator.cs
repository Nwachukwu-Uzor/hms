using FluentValidation;
using HospitalManagement.Application.Contracts.Persistence;

namespace HospitalManagement.Application.Features.Staff;

public class OnboardStaffCommandValidator : AbstractValidator<OnboardStaffCommand>
{
    private readonly IUnitOfWork _unitOfWork;
    public OnboardStaffCommandValidator(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;

        RuleFor(p => p.Email)
            .EmailAddress().WithMessage("{PropertyName} must be a valid email address")
            .NotNull().WithMessage("{PropertyName} is required")
            .MustAsync(IsUserEmailUnique)
            .WithMessage("{PropertyName} must be unique");

        RuleFor(p => p.FirstName).NotEmpty()
           .MinimumLength(4).WithMessage("{PropertyName} must be at least 4 characters long");

        RuleFor(p => p.LastName).NotEmpty()
            .MinimumLength(4).WithMessage("{PropertyName} must be at least 4 characters long");

        RuleFor(p => p.Address).NotEmpty()
            .MinimumLength(4).WithMessage("{PropertyName} must be at least 4 characters long");

        RuleFor(p => p.DateOfBirth).NotEmpty()
            .NotNull().WithMessage("{PropertyName must not be empty}")
            .LessThanOrEqualTo(DateTime.Now);

        RuleFor(p => p.JobId).NotEmpty()
            .NotNull().WithMessage("{PropertyName must not be empty}");

        RuleFor(command => command.PhoneNumber)
            .NotEmpty().WithMessage("PhoneNumber is required.");

        RuleFor(command => command.Country)
            .NotEmpty().WithMessage("Country is required.");
    }

    private async Task<bool> IsUserEmailUnique(string email, CancellationToken token)
    {
        return await _unitOfWork.AppUserRepository.IsEmailUnique(email);
    }
}
