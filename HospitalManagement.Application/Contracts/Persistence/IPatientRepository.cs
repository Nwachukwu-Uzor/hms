using HospitalManagement.Domain.Entities;
using HR.LeaveManagement.Application.Contracts.Persistence;

namespace HospitalManagement.Application.Contracts.Persistence;

public interface IPatientRepository : IGenericRepository<Patient>
{
   Task<Patient> GetPatientByPatientID(string patientID);
    Task<Patient> GetPatientByAppUserID(Guid appUserId);
    Task<Patient> GetByIdWithAppUserAsync(Guid id);
}
