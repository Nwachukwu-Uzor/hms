using HospitalManagement.Application.Contracts.Persistence;
using HospitalManagement.Domain.Entities;

namespace HospitalManagement.Persistence.Repositories;

public class PatientRegisterationRequestRepository : GenericRepository<PatientRegisterationRequest>, IPatientRegisterationRequestRepository
{
    public PatientRegisterationRequestRepository(AppDbContext context) : base(context)
    {
    }
}
