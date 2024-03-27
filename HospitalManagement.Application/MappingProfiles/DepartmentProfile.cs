using AutoMapper;
using HospitalManagement.Application.Features.Department;
using HospitalManagement.Domain.Entities;

namespace HospitalManagement.Application.MappingProfiles;

public class DepartmentProfile : Profile
{
    public DepartmentProfile()
    {
        CreateMap<DepartmentDto, Department>().ReverseMap();
        CreateMap<CreateNewDepartmentCommand, Department>().ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name.ToUpper()));
    }
}
