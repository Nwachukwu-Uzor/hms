using AutoMapper;
using HospitalManagement.Application.Features.Department;
using HospitalManagement.Domain.Entities;

namespace HospitalManagement.Application.MappingProfiles;

public class DepartmentProfile : Profile
{
    public DepartmentProfile()
    {
        CreateMap<DepartmentDto, Department>().ReverseMap();
    }
}
