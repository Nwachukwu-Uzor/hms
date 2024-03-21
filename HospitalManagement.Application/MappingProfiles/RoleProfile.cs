using AutoMapper;
using HospitalManagement.Application.Features.Roles.Queries.GetAllRolesQuery;
using HospitalManagement.Domain.Entities;

namespace HospitalManagement.Application.MappingProfiles;

public class RoleProfile : Profile
{
    public RoleProfile()
    {
        CreateMap<Role, RoleDto>();
    }
}
