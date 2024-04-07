using AutoMapper;
using HospitalManagement.Application.Features.Appointment;
using HospitalManagement.Application.Features.Appointment.DTOs;
using HospitalManagement.Domain.Entities;

namespace HospitalManagement.Application.MappingProfiles;

public class AppointmentProfile : Profile
{
    public AppointmentProfile()
    {
        CreateMap<Appointment, AppointmentDto>();
        CreateMap<CreateAppointmentCommand, Appointment>();
    }
}
