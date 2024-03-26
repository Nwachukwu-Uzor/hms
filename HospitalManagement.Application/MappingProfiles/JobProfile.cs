using AutoMapper;
using HospitalManagement.Application.Features.Job.DTOs;
using HospitalManagement.Domain.Entities;

namespace HospitalManagement.Application.MappingProfiles;

public class JobProfile : Profile
{
    public JobProfile()
    {
        CreateMap<Job, JobDto>();
    }
}
