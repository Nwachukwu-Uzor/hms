using HospitalManagement.Application.Contracts.Persistence;
using HospitalManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagement.Persistence.Repositories;

public class PatientRepository : GenericRepository<Patient>, IPatientRepository
{
    public PatientRepository(AppDbContext context) : base(context)
    {
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
