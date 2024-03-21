using HospitalManagement.Application.Contracts.Persistence;
using HospitalManagement.Domain.Entities;

namespace HospitalManagement.Persistence.Repositories
{
    public class RoleRepository : GenericRepository<Role>, IRoleRepository
    {
        public RoleRepository(AppDbContext context) : base(context)
        {
            
        }
    }
}
