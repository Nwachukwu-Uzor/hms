using HospitalManagement.Application.Contracts.Persistence;
using HospitalManagement.Application.Models.Persistence;
using HospitalManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagement.Persistence.Repositories;

public class PatientRepository : GenericRepository<Patient>, IPatientRepository
{
    public PatientRepository(AppDbContext context) : base(context)
    {
    }

    public async override Task<PaginatedData<Patient>> GetAllPaginated(int page, int pageSize)
    {
        var count = await _context.Patients.CountAsync(entity => !entity.IsDeleted);
        var records = await _context.Patients
            .Where(entity => entity.IsDeleted == false)
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .Include(patient => patient.AppUser)
            .ToListAsync();
        var response = new PaginatedData<Patient>(records, pageSize, count, page);
        return response;
    }

    public async Task<Patient> GetByIdWithAppUserAsync(Guid id)
    {
        var patient = await _context.Patients.Include(patient => patient.AppUser).FirstOrDefaultAsync();
        return patient;
    }

    public async Task<Patient> GetPatientByAppUserID(Guid appUserId)
    {
        var patient = await _context.Patients
            .Include(patient => patient.AppUser)
            .Include(patient => patient.AppUser.Roles)
            .FirstOrDefaultAsync(patient => patient.AppUser.Id == appUserId);
        return patient;
    }

    public async Task<Patient> GetPatientByPatientID(string patientID)
    {
        var patient = await _context.Patients
            .Include(patient => patient.AppUser)
            .Include(patient => patient.AppUser.Roles)
            .FirstOrDefaultAsync(patient => patient.PatientID == patientID);
        return patient;
    }
}
