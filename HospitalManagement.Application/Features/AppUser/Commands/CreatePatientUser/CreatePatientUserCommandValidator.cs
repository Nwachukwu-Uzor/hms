using FluentValidation;
using HospitalManagement.Application.Contracts.Persistence;

namespace HospitalManagement.Application.Features.AppUser;

public class CreatePatientUserCommandValidator : AbstractValidator<CreatePatientUserCommand>
{
    private readonly IUnitOfWork _unitOfWork;
    public CreatePatientUserCommandValidator(IUnitOfWork unitOfWork)
    {
        RuleFor(p => p.Email)
            .EmailAddress().WithMessage("{PropertyName} must be a valid email address")
            .NotNull().WithMessage("{PropertyName} is required")
            .MustAsync(IsUserEmailUnique)
            .WithMessage("{PropertyName} must be unique");

        RuleFor(x => x.Password)
        .NotEmpty().WithMessage("Password is required.")
        .MinimumLength(6).WithMessage("Password must be at least 6 characters.");

        RuleFor(x => x.ConfirmPassword)
            .NotEmpty().WithMessage("Confirm password is required.")
            .Equal(x => x.Password).WithMessage("Passwords do not match.");
        _unitOfWork = unitOfWork;
    }


    private async Task<bool> IsUserEmailUnique(string email, CancellationToken token)
    {
        return await _unitOfWork.AppUserRepository.IsEmailUnique(email);
    }
}
