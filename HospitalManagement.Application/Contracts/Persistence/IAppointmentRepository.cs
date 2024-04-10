using HospitalManagement.Application.Models.Persistence;
using HospitalManagement.Domain.Entities;
using HospitalManagement.Domain.Enums;
using HR.LeaveManagement.Application.Contracts.Persistence;

namespace HospitalManagement.Application.Contracts.Persistence;

public interface IAppointmentRepository : IGenericRepository<Appointment>
{
    Task<PaginatedData<Appointment>> GetAllUpcomingAppointmentsPaginated(int page, int pageSize);
    Task<PaginatedData<Appointment>> GetAppointmentsByPatientIdPaginated(string patientId, int page, int pageSize, AppointmentStatus status, DateTime startDate, DateTime endDate);
}
