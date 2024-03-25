using AutoMapper;
using HospitalManagement.Application.Features.Staff.Commands.AddStaff;
using HospitalManagement.Application.Features.Staff.Queries.GetStaffByStaffId;
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
