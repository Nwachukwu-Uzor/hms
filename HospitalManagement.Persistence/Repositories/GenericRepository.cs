using HospitalManagement.Application.Models.Persistence;
using HospitalManagement.Domain.Common;
using HR.LeaveManagement.Application.Contracts.Persistence;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagement.Persistence.Repositories;

public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
{
    protected readonly AppDbContext _context;

    public GenericRepository(AppDbContext context)
    {
        _context = context;
    }
    public async Task<T> CreateAsync(T entity)
    {
        await _context.AddAsync(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<T> DeleteAsync(T entity)
    {
        entity.IsDeleted = true;
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<bool> DoesEntityExistAsync(Guid id)
    {
        return await _context.Set<T>().AnyAsync(entity => entity.Id == id && !entity.IsDeleted);
    }

    public async Task<IReadOnlyList<T>> GetAllAsync()
    {
        var entity = await _context.Set<T>().AsNoTracking().Where(entity => entity.IsDeleted == false).ToListAsync();
        return entity;
    }

    public async Task<PaginatedData<T>> GetAllPaginated(int page, int pageSize)
    {
        var count = await _context.Set<T>().CountAsync(entity => !entity.IsDeleted);      
        var records = await _context.Set<T>()
            .Where(entity => entity.IsDeleted == false)
            .Skip((page - 1) * pageSize)
            .Take(pageSize).ToListAsync();
        var response =  new PaginatedData<T>()
        {
            Data = records,
            PageCount = count,
            PageSize = pageSize,
            Page = page
        };
        return response;
    }

    public async Task<T> GetByIdAsync(Guid id)
    {
        var entity = await _context.Set<T>()
            .AsNoTracking()
            .FirstOrDefaultAsync(item => item.Id == id && !item.IsDeleted);
        return entity;
    }

    public async Task<T> UpdateAsync(T entity)
    {
        _context.Update(entity);
        _context.Entry(entity).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return entity;
    }
}
