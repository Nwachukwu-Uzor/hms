using HospitalManagement.Application.Contracts.Persistence;
using HospitalManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagement.Persistence.Repositories;

public class StaffRepository : GenericRepository<Staff>, IStaffRepository
{
    public StaffRepository(AppDbContext context) : base(context)
    {
        
    }

    public async Task<Staff> GetStaffByAppUserId(Guid appUserId)
    {
        var staff = await _context.Staffs.FirstOrDefaultAsync(staff => staff.AppUser.Id == appUserId);
        return staff;
    }

    public async Task<Staff> GetStaffByStaffID(string staffID)
    {
        var staff = await _context.Staffs
            .Include(st => st.AppUser).Include(st => st.AppUser.Roles)
            .Include(st => st.Job.Department)
            .FirstOrDefaultAsync(staff => staff.StaffID == staffID);
        return staff;
    }
}
