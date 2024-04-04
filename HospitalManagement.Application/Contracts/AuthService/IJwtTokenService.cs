using HospitalManagement.Application.Features.AppUser;
using HospitalManagement.Application.Models.AuthService;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;

namespace HospitalManagement.Application.Contracts.AuthService;

public interface IJwtTokenService
{
    TokenData GenerateToken(AppUserDto user);
    JwtSecurityToken DecodeToken(string token);
}
