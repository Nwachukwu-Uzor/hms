using FluentValidation;
using HospitalManagement.Application.Extensions.Validation;

namespace HospitalManagement.Application.Features.PatientRegisterationRequest;

public class VerifyPatientRegisterationRequestCommandValidator : AbstractValidator<VerifyPatientRegisterationRequestCommand>
{
    public VerifyPatientRegisterationRequestCommandValidator()
    {
        RuleFor(member => member.Id.ToString())
            .NotEmpty()
            .NotNull().WithMessage("{PropertyName} is required")
            .IsGuid().WithMessage("{PropertyName} is invalid");

        RuleFor(member => member.AccessCode)
            .NotEmpty().NotNull();
    }
}
