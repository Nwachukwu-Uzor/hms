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
        private readonly IRoleManager _roleManager;
        private readonly RolesId _rolesId;
        private readonly IUnitOfWork _unitOfWork;

        public CreatePatientUserCommandHandler(
        IPasswordService passwordManager,
        IRoleManager roleManager,
        IOptions<RolesId> option,
        IUnitOfWork unitOfWork)
        {
            _passwordManager = passwordManager;
            _roleManager = roleManager;
            _rolesId = option.Value;
            _unitOfWork = unitOfWork;
        }
        public async Task<Guid> Handle(CreatePatientUserCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreatePatientUserCommandValidator(_unitOfWork);

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
            var user = await _unitOfWork.AppUserRepository.CreateAsync(appUser);
            await _unitOfWork.CompleteAsync();
            await _roleManager.AddUserToRole(appUser.Id, _rolesId.PatientRoleId);
            return user.Id;
        }
    }
}
