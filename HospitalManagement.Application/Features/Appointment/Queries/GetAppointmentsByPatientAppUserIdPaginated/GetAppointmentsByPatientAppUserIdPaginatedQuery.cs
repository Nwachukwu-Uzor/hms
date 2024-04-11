using HospitalManagement.Application.Features.Appointment.DTOs;
using HospitalManagement.Application.Models.Persistence;
using HospitalManagement.Domain.Enums;
using MediatR;

namespace HospitalManagement.Application.Features.Appointment;

public class GetAppointmentsByPatientAppUserIdPaginatedQuery
: IRequest<PaginatedData<AppointmentDto>>
{
    public Guid PatientId { get; set; }
    public int Page { get; set; }
    public int PageSize { get; set; }
    public DateTime StartDate { get; set; } = DateTime.UtcNow;
    public DateTime EndDate { get; set; } = DateTime.UtcNow;
    public AppointmentStatus Status { get; set; } = AppointmentStatus.PENDING;
}