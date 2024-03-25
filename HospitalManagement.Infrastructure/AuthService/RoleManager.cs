using HospitalManagement.Application.Contracts.AuthService;
using HospitalManagement.Application.Contracts.Persistence;
using HospitalManagement.Application.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Infrastructure.AuthService;

public class RoleManager : IRoleManager
{
    private readonly IAppUserRepository _appUserRepository;
    private readonly IRoleRepository _roleRepository;

    public RoleManager(IAppUserRepository appUserRepository, IRoleRepository roleRepository)
    {
        _appUserRepository = appUserRepository;
        _roleRepository = roleRepository;
    }

    public async Task AddUserToRole(Guid userId, Guid roleId)
    {
        var user = await _appUserRepository.GetByUserWithRolesById(userId);
        if (user == null)
        {
            throw new NotFoundException($"{nameof(Domain.Entities.AppUser)}", userId);
        }

        var role = await _roleRepository.GetByIdAsync(roleId);
        if (role == null)
        {
            throw new NotFoundException($"{nameof(Domain.Entities.Role)}", roleId);
        }
        if (user.Roles == null)
        {
            user.Roles = new();
        }

        var doesUserAlreadyHaveRole = user.Roles.Any(role => role.Id == roleId);
        if (doesUserAlreadyHaveRole)
        {
            throw new BadRequestException($"User already has the requested role {role.Name}");
        }
        user.Roles.Add(role);
        await _appUserRepository.UpdateAsync(user);
    }

    public Task RemoveUserFromRole(Guid userId, Guid roleId)
    {
        throw new NotImplementedException();
    }
}
