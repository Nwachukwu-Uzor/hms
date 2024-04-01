using HospitalManagement.Application.Contracts.Persistence;
using HospitalManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagement.Persistence.Repositories;

public class PatientRegisterationRequestRepository : GenericRepository<PatientRegisterationRequest>, IPatientRegisterationRequestRepository
{
    public PatientRegisterationRequestRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<PatientRegisterationRequest> GetPatientRegisterRequestByIdAndAccessCode(Guid id, string accessCode)
    {
        var request = await _context.PatientRegisterationRequests
            .Where(req => req.Id == id && req.AccessCode == accessCode && !req.IsDeleted)
            .FirstOrDefaultAsync();
        return request;
    }
}
