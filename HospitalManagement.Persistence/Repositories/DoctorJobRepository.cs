using HospitalManagement.Application.Contracts.Persistence;
using HospitalManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagement.Persistence.Repositories;

public class DoctorJobRepository : GenericRepository<DoctorJob>, IDoctorJobRepository
{
    public DoctorJobRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<bool> IsJobIdADocter(Guid jobId)
    {
        var isJobADoctor = await _context.DoctorJobs.AnyAsync(doctorJob => doctorJob.JobId == jobId);
        return isJobADoctor;
    }
}
