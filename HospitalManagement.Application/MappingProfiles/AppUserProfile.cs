﻿using AutoMapper;
using HospitalManagement.Application.Features.AppUser.Commands.LoginAdminUser;
using HospitalManagement.Domain.Entities;

namespace HospitalManagement.Application.MappingProfiles;

public class AppUserProfile : Profile
{
    public AppUserProfile()
    {
        CreateMap<AppUser, AppUserDto>();
    }
}