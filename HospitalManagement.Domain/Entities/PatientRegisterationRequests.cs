using HospitalManagement.Domain.Common;
using HospitalManagement.Domain.Enums;

namespace HospitalManagement.Domain.Entities;

public class PatientRegisterationRequest : BaseEntity
{
    public string Email { get; set; }
    public string AccessCode { get; set; }

    public DateTime ExpiresOn { get; set; } = DateTime.UtcNow.AddMinutes(60);
    public PatientRequestVerificationStatus VerificationStatus { get; set; } = PatientRequestVerificationStatus.PENDING;
}
