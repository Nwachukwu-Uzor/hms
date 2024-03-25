using HospitalManagement.Domain.Entities;
using HR.LeaveManagement.Application.Contracts.Persistence;

namespace HospitalManagement.Application.Contracts.Persistence;

public interface IStaffRepository : IGenericRepository<Staff>
{
    Task<Staff> GetStaffByStaffID(string staffID);
    Task<Staff> GetStaffByAppUserId(Guid appUserId);
}
