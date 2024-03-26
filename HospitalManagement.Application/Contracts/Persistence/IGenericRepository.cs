using HospitalManagement.Application.Models.Persistence;
using HospitalManagement.Domain.Common;

namespace HR.LeaveManagement.Application.Contracts.Persistence;

public interface IGenericRepository<T> where T : BaseEntity
{
    Task<T> CreateAsync(T entity);
    T UpdateAsync(T entity);
    Task<T> DeleteAsync(T entity);
    Task<IReadOnlyList<T>> GetAllAsync();
    Task<T> GetByIdAsync(Guid id);
    Task<bool> DoesEntityExistAsync(Guid id);
    Task<PaginatedData<T>> GetAllPaginated(int page, int pageSize);
}

