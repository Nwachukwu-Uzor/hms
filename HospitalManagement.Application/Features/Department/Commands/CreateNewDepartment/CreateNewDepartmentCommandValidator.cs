using FluentValidation;
using HospitalManagement.Application.Contracts.Persistence;

namespace HospitalManagement.Application.Features.Department;

public class CreateNewDepartmentCommandValidator : AbstractValidator<CreateNewDepartmentCommand>
{
    private readonly IUnitOfWork _unitOfWork;

    public CreateNewDepartmentCommandValidator(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;

        RuleFor(member => member.Name)
            .NotEmpty().WithMessage("{PropertyName} cannot be empty")
            .MinimumLength(3).WithMessage("{PropertyName} must be at least 3 characters long")
            .MustAsync(IsDepartmentNameUnique).WithMessage("{PropertyName} already used by another department");
    }

    private async Task<bool> IsDepartmentNameUnique(string name, CancellationToken token)
    {
        return await _unitOfWork.DepartmentRepository.IsDepartmentNameUnique(name);
    }
}
