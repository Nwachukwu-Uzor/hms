using HospitalManagement.Application.Contracts.Persistence;
using HospitalManagement.Domain.Entities;

namespace HospitalManagement.Persistence.Repositories;

public class DepartmentRepository : GenericRepository<Department>, IDepartmentRepository
{
    public DepartmentRepository(AppDbContext context) : base(context)
    {
        
    }
}
