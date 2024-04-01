using AutoMapper;
using HospitalManagement.Application.Features;
using HospitalManagement.Domain.Entities;

namespace HospitalManagement.Application.MappingProfiles;

public class PatientRegisterationRequestProfile : Profile
{
    public PatientRegisterationRequestProfile()
    {
        CreateMap<PatientRegisterationRequest, PatientRegisterationRequestDTO>();
    }
}
