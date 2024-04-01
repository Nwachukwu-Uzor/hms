using HospitalManagement.Domain.Entities;
using HR.LeaveManagement.Application.Contracts.Persistence;

namespace HospitalManagement.Application.Contracts.Persistence;

public interface IPatientRegisterationRequestRepository : IGenericRepository<PatientRegisterationRequest>
{
    Task<PatientRegisterationRequest> GetPatientRegisterRequestByIdAndAccessCode(Guid id, string accessCode);
}
