using AutoMapper;
using HospitalManagement.Application.Features.Patient.Commands.CompletePatientDetails;
using HospitalManagement.Application.Features.Patient.DTOs;

namespace HospitalManagement.Application.MappingProfiles;

public class PatientProfile : Profile
{
    public PatientProfile()
    {
        CreateMap<CompletePatientDetailsCommand, Domain.Entities.Patient>();
        CreateMap<Domain.Entities.Patient, PatientDto>();
    }
}
