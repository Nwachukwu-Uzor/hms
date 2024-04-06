using AutoMapper;
using HospitalManagement.Application.Features.Doctor.DTOs;
using HospitalManagement.Domain.Entities;

namespace HospitalManagement.Application.MappingProfiles;

public class DoctorProfile : Profile
{
    public DoctorProfile()
    {
        CreateMap<Doctor, DoctorDto>();
    }
}
