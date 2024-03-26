using AutoMapper;
using HospitalManagement.Application.Features.Staff;
using HospitalManagement.Domain.Entities;

namespace HospitalManagement.Application.MappingProfiles;

public class StaffProfile : Profile
{
    public StaffProfile()
    {
        CreateMap<AddStaffCommand, Staff>();
        CreateMap<Staff, StaffDto>();
    }
}
