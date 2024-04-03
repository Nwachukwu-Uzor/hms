using HospitalManagement.Application.Features.AppUser;
using HospitalManagement.Application.Models.AuthService;
using Microsoft.IdentityModel.Tokens;

namespace HospitalManagement.Application.Contracts.AuthService;

public interface IJwtTokenService
{
    TokenData GenerateToken(AppUserDto user);
    SecurityToken DecodeToken(string token);
}
