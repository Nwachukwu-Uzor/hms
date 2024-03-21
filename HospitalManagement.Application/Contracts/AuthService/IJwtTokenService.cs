using HospitalManagement.Application.Features.AppUser.Commands.LoginUserCommand;

namespace HospitalManagement.Application.Contracts.AuthService;

public interface IJwtTokenService
{
    string GenerateToken(AppUserDto user);
}
