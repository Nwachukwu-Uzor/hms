using HospitalManagement.Application.Features.Appointment.DTOs;
using HospitalManagement.Application.Models.Persistence;
using MediatR;

namespace HospitalManagement.Application.Features.Appointment;

public record GetAllUpcomingAppointmentsPaginatedQuery(int Page, int PageSize) : IRequest<PaginatedData<AppointmentDto>>;
