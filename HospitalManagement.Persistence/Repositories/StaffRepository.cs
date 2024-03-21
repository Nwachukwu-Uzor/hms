using HospitalManagement.Application.Contracts.Persistence;
using HospitalManagement.Domain.Entities;

namespace HospitalManagement.Persistence.Repositories;

public class StaffRepository : GenericRepository<Staff>, IStaffRepository
{
    public StaffRepository(AppDbContext context) : base(context)
    {
        
    }
}
