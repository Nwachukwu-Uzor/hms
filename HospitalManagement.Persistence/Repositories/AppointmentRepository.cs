using HospitalManagement.Application.Contracts.Persistence;
using HospitalManagement.Domain.Entities;

namespace HospitalManagement.Persistence.Repositories;

public class AppointmentRepository : GenericRepository<Appointment>, IAppointmentRepository
{
    public AppointmentRepository(AppDbContext context) : base(context)
    {
    }
}
