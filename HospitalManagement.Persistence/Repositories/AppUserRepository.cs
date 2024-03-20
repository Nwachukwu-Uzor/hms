using HospitalManagement.Application.Contracts.Persistence;
using HospitalManagement.Domain.Entities;

namespace HospitalManagement.Persistence.Repositories;

public class AppUserRepository : GenericRepository<AppUser>, IAppUserRepository
{
}
