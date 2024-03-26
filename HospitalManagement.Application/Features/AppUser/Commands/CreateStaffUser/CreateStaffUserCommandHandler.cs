using HospitalManagement.Application.Contracts.AuthService;
using HospitalManagement.Application.Contracts.Persistence;
using HospitalManagement.Application.Exceptions;
using HospitalManagement.Application.Models.AuthService;
using MediatR;
using Microsoft.Extensions.Options;

namespace HospitalManagement.Application.Features.AppUser;

public class CreateStaffUserCommandHandler : IRequestHandler<CreateStaffUserCommand, Guid>
{
    private readonly IRoleManager _roleManager;
    private readonly RolesId _rolesId;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IPasswordService _passwordService;
    public CreateStaffUserCommandHandler(
        IRoleManager roleManager,
        IOptions<RolesId> option,
        IUnitOfWork unitOfWork,
        IPasswordService passwordService
    )
    {
        _roleManager = roleManager;
        _rolesId = option.Value;
        _unitOfWork = unitOfWork;
        _passwordService = passwordService;
    }
    public async Task<Guid> Handle(CreateStaffUserCommand request, CancellationToken cancellationToken)
    {
        var validator = new CreateStaffUserCommandValidator(_unitOfWork);
        var validationResult = await validator.ValidateAsync( request );
        if (validationResult.Errors.Any())
        {
            throw new BadRequestException($"{nameof(Domain.Entities.AppUser)} returns validation errors", validationResult);
        }
        var passwordHash = _passwordService.HashPassword(request.Password);
        var appUser = new Domain.Entities.AppUser()
        {
            Email = request.Email,
            Password = passwordHash.Hash,
            Salt = passwordHash.Salt
        };
        var user = await _unitOfWork.AppUserRepository.CreateAsync(appUser);
        await _unitOfWork.CompleteAsync();
        await _roleManager.AddUserToRole(appUser.Id, _rolesId.StaffRoleId);
        return user.Id;
    }
}
