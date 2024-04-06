using AutoMapper;
using HospitalManagement.Application.Features.Patient;
using HospitalManagement.Application.Features.Patient.DTOs;
using HospitalManagement.Application.Models.Persistence;
using HospitalManagement.Domain.Entities;

namespace HospitalManagement.Application.MappingProfiles;

public class PatientProfile : Profile
{
    public PatientProfile()
    {
        CreateMap<CompletePatientDetailsCommand, Patient>();
        CreateMap<Patient, PatientDto>();
        CreateMap<PaginatedData<Patient>, PaginatedData<PatientDto>>();
    }
}
