﻿using FluentValidation;
using HospitalManagement.Application.Contracts.Persistence;

namespace HospitalManagement.Application.Features.AppUser.Commands.CreateAdminUserCommand;

public class CreateAdminUserCommandValidator : AbstractValidator<CreateAdminUserCommand>
{
    private readonly IAppUserRepository _appUserRepository;
    public CreateAdminUserCommandValidator(IAppUserRepository appUserRepository)
    {
        _appUserRepository = appUserRepository;

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
       return await _appUserRepository.IsEmailUnique(email);
    }
}