using HospitalManagement.Application.Contracts.Persistence;
using HospitalManagement.Application.Models.Persistence;
using HospitalManagement.Domain.Entities;
using HospitalManagement.Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagement.Persistence.Repositories;

public class AppointmentRepository : GenericRepository<Appointment>, IAppointmentRepository
{
    public AppointmentRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<PaginatedData<Appointment>> GetAllUpcomingAppointmentsPaginated(int page, int pageSize)
    {
        // Calculate the current date without time
        DateTime currentDate = DateTime.UtcNow.Date;
        // Get count of all upcoming appointments
        var count = await _context.Appointments.CountAsync(a => a.AppointmentTime.Date >= currentDate && a.Status == AppointmentStatus.PENDING);

        // Retrieve appointments that are for the current day and beyond with "PENDING" status
        var appointments = await _context.Appointments
            .Include(appointment => appointment.Patient)
            .Include(appointment => appointment.Doctor.Staff)
            .Where(a => a.AppointmentTime.Date >= currentDate && a.Status == AppointmentStatus.PENDING)
            .OrderBy(a => a.AppointmentTime)
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
        var paginatedResponse = new PaginatedData<Appointment>(appointments, pageSize, count, page);
        return paginatedResponse;
    }
}
