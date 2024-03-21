using HospitalManagement.Application.Contracts.Persistence;
using HospitalManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagement.Persistence.Repositories;

public class AppUserRepository : GenericRepository<AppUser>, IAppUserRepository
{
    public AppUserRepository(AppDbContext context) : base(context)
    {
        
    }
    public async Task<AppUser> GetByEmail(string email)
    {
       var appUser = await _context.AppUsers
            .AsNoTracking().Include(user => user.Roles).FirstOrDefaultAsync(user => user.Email.ToLower() == email.ToLower());
        return appUser;
    }

    public async Task<AppUser> GetByUserWithRolesById(Guid userId)
    {
        var userWithRoles = await _context.AppUsers.Include(user => user.Roles)
            .FirstOrDefaultAsync(user => user.Id == userId);
        return userWithRoles;
    }

    public async Task<bool> IsEmailUnique(string email)
    {
        var userWithEmail = await _context.AppUsers.AnyAsync(user => user.Email.ToLower() == email.ToLower());
        return userWithEmail == false;
    }
}
