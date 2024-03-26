using HospitalManagement.Application.Contracts.Persistence;
using HospitalManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagement.Persistence.Repositories;

public class JobRepository : GenericRepository<Job>, IJobRepository
{
    public JobRepository(AppDbContext context) : base(context)
    {
        
    }

    public async Task<List<Job>> GetAllJobsByDepartmentIdAsync(Guid DepartmentId)
    {
        var jobs = await _context.Jobs.AsNoTracking()
            .Where(job => job.DepartmentId == DepartmentId)
            .ToListAsync();
        return jobs;
    }
}
