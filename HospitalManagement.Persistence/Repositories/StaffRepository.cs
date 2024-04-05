using HospitalManagement.Application.Contracts.Persistence;
using HospitalManagement.Application.Models.Persistence;
using HospitalManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagement.Persistence.Repositories;

public class StaffRepository : GenericRepository<Staff>, IStaffRepository
{
    public StaffRepository(AppDbContext context) : base(context)
    {
        
    }

    public override async  Task<PaginatedData<Staff>> GetAllPaginated(int page, int pageSize)
    {
        var count = await _context.Staffs.CountAsync(entity => !entity.IsDeleted);
        var records = await _context.Staffs
            .Where(entity => entity.IsDeleted == false)
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .Include(staff => staff.Job.Department)
            .Include(staff => staff.AppUser)
            .ToListAsync();
        var response = new PaginatedData<Staff>(records, pageSize, count, page);
        return response;
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
