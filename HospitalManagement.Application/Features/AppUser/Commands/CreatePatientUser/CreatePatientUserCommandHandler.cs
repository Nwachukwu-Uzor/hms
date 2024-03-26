using HospitalManagement.Application.Contracts.AuthService;
using HospitalManagement.Application.Contracts.Persistence;
using HospitalManagement.Application.Exceptions;
using HospitalManagement.Application.Models.AuthService;
using MediatR;
using Microsoft.Extensions.Options;

namespace HospitalManagement.Application.Features.AppUser
{
    public class CreatePatientUserCommandHandler : IRequestHandler<CreatePatientUserCommand, Guid>
    {
        private readonly IPasswordService _passwordManager;
        private readonly IAppUserRepository _appUserRepository;
        private readonly IRoleManager _roleManager;
        private readonly RolesId _rolesId;

        public CreatePatientUserCommandHandler(
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
        public async Task<Guid> Handle(CreatePatientUserCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreatePatientUserCommandValidator(_appUserRepository);

            var validationResult = await validator.ValidateAsync(request);
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
            var user = await _appUserRepository.CreateAsync(appUser);
            await _roleManager.AddUserToRole(appUser.Id, _rolesId.PatientRoleId);
            return user.Id;
        }
    }
}
