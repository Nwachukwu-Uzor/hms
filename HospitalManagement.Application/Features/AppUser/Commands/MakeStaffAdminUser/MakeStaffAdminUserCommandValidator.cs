using FluentValidation;
using HospitalManagement.Application.Models.IDGenerator;

namespace HospitalManagement.Application.Features.AppUser;

public class MakeStaffAdminUserCommandValidator : AbstractValidator<MakeStaffAdminUserCommand>
{
    private readonly IDSettings _idSettings;

    public MakeStaffAdminUserCommandValidator(IDSettings idSettings)
    {
        _idSettings = idSettings;
        var minIdLength = _idSettings.StaffIDPrefix.Length + _idSettings.IDLength;
        RuleFor(p => p.StaffID).NotEmpty()
            .WithMessage("{PropertyName} is cannot be empty")
            .NotNull().WithMessage("{PropertyName} is cannot be empty")
            .MinimumLength(minIdLength)
            .WithMessage($"StaffID must be at least {minIdLength} characters long");
    }
}
