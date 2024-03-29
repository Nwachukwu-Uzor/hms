﻿using HospitalManagement.Application.Features.AppUser;
using HospitalManagement.Application.Models.AuthService;

namespace HospitalManagement.Application.Contracts.AuthService;

public interface IJwtTokenService
{
    TokenData GenerateToken(AppUserDto user);
}
