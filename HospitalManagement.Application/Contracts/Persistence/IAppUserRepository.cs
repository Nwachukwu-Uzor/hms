using HospitalManagement.Domain.Entities;
using HR.LeaveManagement.Application.Contracts.Persistence;

namespace HospitalManagement.Application.Contracts.Persistence;

public interface IAppUserRepository : IGenericRepository<AppUser>
{
    Task<bool> IsEmailUnique(string email);
    Task<AppUser> GetByEmail(string email);
    Task<AppUser> GetByUserWithRolesById(Guid userId);
}