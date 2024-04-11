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
        DateTime currentDate = DateTime.UtcNow.Date.AddDays(-1);
        // Get count of all upcoming appointments
        var count = await _context.Appointments.CountAsync(a => a.AppointmentTime.Date >= currentDate && a.Status == AppointmentStatus.PENDING);
        //var count = await _context.Appointments.CountAsync(a => a.Status == AppointmentStatus.PENDING);

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

    public async Task<PaginatedData<Appointment>> GetAppointmentsByPatientIdPaginated(
        string patientId,
        int page, 
        int pageSize,
        AppointmentStatus status,
        DateTime startDate, 
        DateTime endDate
    )
    {
        var isSameDay = startDate.Date == endDate.Date;

        int count;

        if (isSameDay)
        {
            count = await _context.Appointments.CountAsync(app => 
                app.AppointmentTime.Date >= startDate.AddDays(-1)
                && app.Status == status
                && app.Patient.PatientID == patientId
            );
        } else
        {
            count = await _context.Appointments.CountAsync(app => 
                app.AppointmentTime.Date >= startDate.AddDays(-1) 
                && app.AppointmentTime.Date < endDate.AddDays(1)
                && app.Status == status
                && app.Patient.PatientID == patientId
           );
        }
        var appointments = _context.Appointments.Where(app => app.Patient.PatientID == patientId).Include(app => app.Patient).Include(app => app.Doctor.Staff);
        if (isSameDay)
        {
            appointments.Where(app => 
                app.AppointmentTime.Date >= startDate.AddDays(-1)
                && app.Status == status
            );
        } else
        {
            appointments.Where(app => 
                app.AppointmentTime.Date >= startDate.AddDays(-1) 
                && app.AppointmentTime.Date < endDate.AddDays(1)
                && app.Status == status
           );
        }
        var data = await appointments.ToListAsync();
        var paginatedResponse = new PaginatedData<Appointment>(data, pageSize, count, page);
        return paginatedResponse;
    }

    public async Task<PaginatedData<Appointment>> GetAppointmentsByPatientIdPaginated(
       Guid patientId,
       int page,
       int pageSize,
       AppointmentStatus status,
       DateTime startDate,
       DateTime endDate
   )
    {
        var isSameDay = startDate.Date == endDate.Date;

        int count;

        if (isSameDay)
        {
            count = await _context.Appointments.CountAsync(app =>
                app.AppointmentTime.Date >= startDate.AddDays(-1)
                && app.Status == status
                && app.Patient.AppUser.Id == patientId
            );
        }
        else
        {
            count = await _context.Appointments.CountAsync(app =>
                app.AppointmentTime.Date >= startDate.AddDays(-1)
                && app.AppointmentTime.Date < endDate.AddDays(1)
                && app.Status == status
                && app.Patient.AppUser.Id == patientId
           );
        }
        var appointments = _context.Appointments.Where(app => app.Patient.AppUser.Id == patientId).Include(app => app.Patient).Include(app => app.Doctor.Staff);
        if (isSameDay)
        {
            appointments.Where(app =>
                app.AppointmentTime.Date >= startDate.AddDays(-1)
                && app.Status == status
            );
        }
        else
        {
            appointments.Where(app =>
                app.AppointmentTime.Date >= startDate.AddDays(-1)
                && app.AppointmentTime.Date < endDate.AddDays(1)
                && app.Status == status
           );
        }
        var data = await appointments.ToListAsync();
        var paginatedResponse = new PaginatedData<Appointment>(data, pageSize, count, page);
        return paginatedResponse;
    }
}
