using FluentValidation;
using HospitalManagement.Application.Contracts.Persistence;

namespace HospitalManagement.Application.Features.Patient;

public class OnboardPatientCommandValidator : AbstractValidator<OnboardPatientCommand>
{
    private readonly IUnitOfWork _unitOfWork;
    public OnboardPatientCommandValidator(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
        RuleFor(member => member.Email)
            .NotEmpty().WithMessage("{PropertyName} is required")
            .NotNull()
            .EmailAddress().WithMessage("{PropertyName} must be a valid email account")
            .MustAsync(IsEmailUnique).WithMessage("{PropertyName} is already used");

        RuleFor(p => p.FirstName).NotEmpty()
            .MinimumLength(4).WithMessage("{PropertyName} must be at least 4 characters long");

        RuleFor(p => p.LastName).NotEmpty()
            .MinimumLength(4).WithMessage("{PropertyName} must be at least 4 characters long");

        RuleFor(p => p.Address).NotEmpty()
            .MinimumLength(4).WithMessage("{PropertyName} must be at least 4 characters long");

        RuleFor(p => p.DateOfBirth).NotEmpty()
            .NotNull().WithMessage("{PropertyName must not be empty}")
            .LessThanOrEqualTo(DateTime.Now);

        RuleFor(command => command.Genotype)
            .NotEmpty().WithMessage("Genotype is required.")
            .Must(BeAValidGenotype).WithMessage("Invalid Genotype. Genotype must be one of (A, B, AB, O)");

        RuleFor(command => command.BloodGroup)
            .NotEmpty().WithMessage("BloodGroup is required.")
            .Must(BeAValidBloodGroup).WithMessage("Invalid BloodGroup. Blood group must be one of (AA, AO, BB, BO, AB, OO)");

        RuleFor(command => command.PhoneNumber)
            .NotEmpty().WithMessage("PhoneNumber is required.");

        RuleFor(command => command.Country)
            .NotEmpty().WithMessage("Country is required.");
    }

    private bool BeAValidGenotype(string genotype)
    {
        // Add your validation logic here
        // Example: Check if genotype is one of the common blood types (A, B, AB, O)
        return genotype == "A" || genotype == "B" || genotype == "AB" || genotype == "O";
    }

    private bool BeAValidBloodGroup(string bloodGroup)
    {
        // Add your validation logic here
        // Example: Check if bloodGroup is one of the common blood groups (AA, AO, BB, BO, AB, OO)
        return bloodGroup == "AA" || bloodGroup == "AO" || bloodGroup == "BB" ||
               bloodGroup == "BO" || bloodGroup == "AB" || bloodGroup == "OO";
    }

    private async Task<bool> IsEmailUnique(string email, CancellationToken token)
    {
        var isEmailUnique = await _unitOfWork.AppUserRepository.IsEmailUnique(email);
        return isEmailUnique;
    }
}
