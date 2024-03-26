using HospitalManagement.Domain.Entities;
using HR.LeaveManagement.Application.Contracts.Persistence;

namespace HospitalManagement.Application.Contracts.Persistence;

public interface IJobRepository : IGenericRepository<Job>
{
    Task<List<Job>> GetAllJobsByDepartmentIdAsync(Guid DepartmentId);
}
