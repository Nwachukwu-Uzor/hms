using HospitalManagement.Application.Contracts.Persistence;
using HospitalManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagement.Persistence.Repositories;

public class DoctorRepository : GenericRepository<Doctor>, IDoctorRepository
{
    public DoctorRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<List<Doctor>> GetAllWithStaffDetails()
    {
        var doctor = await _context.Doctors.Include(doc => doc.Staff.Job.Department)
            .Where(doc => !doc.IsDeleted && !doc.Staff.IsDeleted && !doc.Staff.AppUser.IsDeleted).ToListAsync();
        return doctor;
    }
}
