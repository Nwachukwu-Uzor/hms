using HospitalManagement.Domain.Entities;
using HR.LeaveManagement.Application.Contracts.Persistence;

namespace HospitalManagement.Application.Contracts.Persistence;

public interface IDoctorJobRepository : IGenericRepository<DoctorJob>
{
    Task<bool> IsJobIdADocter(Guid jobId);
}
