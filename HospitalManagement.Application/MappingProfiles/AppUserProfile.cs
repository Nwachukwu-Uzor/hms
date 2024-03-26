using AutoMapper;
using HospitalManagement.Application.Features.AppUser;
using HospitalManagement.Domain.Entities;

namespace HospitalManagement.Application.MappingProfiles;

public class AppUserProfile : Profile
{
    public AppUserProfile()
    {
        CreateMap<AppUser, AppUserDto>();
    }
}
