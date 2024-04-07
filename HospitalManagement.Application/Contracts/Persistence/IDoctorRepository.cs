using HospitalManagement.Domain.Entities;
using HR.LeaveManagement.Application.Contracts.Persistence;

namespace HospitalManagement.Application.Contracts.Persistence;

public interface IDoctorRepository : IGenericRepository<Doctor>
{
    Task<List<Doctor>> GetAllWithStaffDetails();
}
