using HospitalManagement.Application.Contracts.Persistence;
using HospitalManagement.Domain.Entities;

namespace HospitalManagement.Persistence.Repositories;

public class DoctorJobRepository : GenericRepository<DoctorJob>, IDoctorJobRepository
{
    public DoctorJobRepository(AppDbContext context) : base(context)
    {
    }
}
