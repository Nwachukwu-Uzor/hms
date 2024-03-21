using HospitalManagement.Application.Contracts.AuthService;
using HospitalManagement.Application.Contracts.Persistence;
using HospitalManagement.Application.Exceptions;
using MediatR;

namespace HospitalManagement.Application.Features.AppUser.Commands.CreateAdminUserCommand;

public class CreateAdminUserCommandHandler : IRequestHandler<CreateAdminUserCommand, Unit>
{
    private readonly IPasswordService _passwordManager;
    private readonly IAppUserRepository _appUserRepository;
    public CreateAdminUserCommandHandler(
        IPasswordService passwordManager, 
        IAppUserRepository appUserRepository
    )
    {
        _passwordManager = passwordManager;
        _appUserRepository = appUserRepository;
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
        return Unit.Value;
    }
}
