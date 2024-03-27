using HospitalManagement.Application.Contracts.Persistence;
using HospitalManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagement.Persistence.Repositories;

public class DepartmentRepository : GenericRepository<Department>, IDepartmentRepository
{
    public DepartmentRepository(AppDbContext context) : base(context)
    {
        
    }

    public async Task<bool> IsDepartmentNameUnique(string Name)
    {
        var departmentNameExists = await _context.Departments.AnyAsync(dept => dept.Name.Trim().ToUpper() == Name.Trim().ToUpper());
        return !departmentNameExists;
    }
}
