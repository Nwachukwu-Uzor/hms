using HospitalManagement.Application.Models.Persistence;
using HospitalManagement.Domain.Entities;
using HR.LeaveManagement.Application.Contracts.Persistence;

namespace HospitalManagement.Application.Contracts.Persistence;

public interface IAppointmentRepository : IGenericRepository<Appointment>
{
    Task<PaginatedData<Appointment>> GetAllUpcomingAppointmentsPaginated(int page, int pageSize);
}
