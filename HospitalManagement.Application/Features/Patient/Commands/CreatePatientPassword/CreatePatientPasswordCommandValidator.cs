using FluentValidation;
using HospitalManagement.Application.Extensions.Validation;

namespace HospitalManagement.Application.Features.Patient;

public class CreatePatientPasswordCommandValidator : AbstractValidator<CreatePatientPasswordCommand>
{
    public CreatePatientPasswordCommandValidator()
    {
        RuleFor(x => x.PatientRegisterationRequestId.ToString())
            .NotEmpty().NotNull()
            .IsGuid().WithMessage("{PropertyName} is not a valid Id");

        RuleFor(x => x.Password)
        .NotEmpty().WithMessage("Password is required.")
        .MinimumLength(6).WithMessage("Password must be at least 6 characters.");

        RuleFor(x => x.ConfirmPassword)
            .NotEmpty().WithMessage("Confirm password is required.")
            .Equal(x => x.Password).WithMessage("Passwords do not match.");
    }
}
