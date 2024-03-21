using HospitalManagement.Application.Contracts.AuthService;
using HospitalManagement.Application.Contracts.Persistence;
using HospitalManagement.Application.Exceptions;
using HospitalManagement.Application.Models.AuthService;
using MediatR;
using Microsoft.Extensions.Options;

namespace HospitalManagement.Application.Features.AppUser.Commands.CreateAdminUserCommand;

public class CreateAdminUserCommandHandler : IRequestHandler<CreateAdminUserCommand, Unit>
{
    private readonly IPasswordService _passwordManager;
    private readonly IAppUserRepository _appUserRepository;
    private readonly IRoleManager _roleManager;
    private readonly RolesId _rolesId;
    public CreateAdminUserCommandHandler(
        IPasswordService passwordManager,
        IAppUserRepository appUserRepository,
        IRoleManager roleManager,
        IOptions<RolesId> option
    )
    {
        _passwordManager = passwordManager;
        _appUserRepository = appUserRepository;
        _roleManager = roleManager;
        _rolesId = option.Value;
    }
    public async Task<Unit> Handle(CreateAdminUserCommand request, CancellationToken cancellationToken)
    {
        var validator = new CreateAdminUserCommandValidator(_appUserRepository);
        var validationResult = await validator.ValidateAsync( request );
        if (validationResult.Errors.Any())
        {
            throw new BadRequestException($"{nameof(Domain.Entities.AppUser)} returns validation errors", validationResult);
        }
        var passwordHash = _passwordManager.HashPassword(request.Password);
        var appUser = new Domain.Entities.AppUser()
        {
            Email = request.Email,
            Password = passwordHash.Hash,
            Salt = passwordHash.Salt
        };
        await _appUserRepository.CreateAsync(appUser);
        await _roleManager.AddUserToRole(appUser.Id, _rolesId.AdminRoleId);
        return Unit.Value;
    }
}
