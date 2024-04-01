using FluentValidation;
using HospitalManagement.Application.Contracts.Persistence;

namespace HospitalManagement.Application.Features.PatientRegisterationRequest;

public class CreatePatientRegisterationRequestCommandValidator : AbstractValidator<CreatePatientRegisterationRequestCommand>
{
    private readonly IUnitOfWork _unitOfWork;
    public CreatePatientRegisterationRequestCommandValidator(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
        RuleFor(member => member.Email)
            .NotEmpty().WithMessage("{PropertyName} is required")
            .NotNull()
            .EmailAddress().WithMessage("{PropertyName} must be a valid email account")
            .MustAsync(IsEmailUnique).WithMessage("{Property} is already used");

    }

    private async Task<bool> IsEmailUnique(string email, CancellationToken token)
    {
        var isEmailUnique = await _unitOfWork.AppUserRepository.IsEmailUnique(email);
        return isEmailUnique;
    }
}
