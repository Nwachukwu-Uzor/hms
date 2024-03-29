﻿using FluentValidation;
using HospitalManagement.Application.Contracts.Persistence;

namespace HospitalManagement.Application.Features.AppUser;

public class CreateStaffUserCommandValidator : AbstractValidator<CreateStaffUserCommand>
{
    private readonly IAppUserRepository _appUserRepository;
    private readonly IUnitOfWork _unitOfWork;
    public CreateStaffUserCommandValidator(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
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
    }

    private async Task<bool> IsUserEmailUnique(string email, CancellationToken token)
    {
       return await _unitOfWork.AppUserRepository.IsEmailUnique(email);
    }
}