using HospitalManagement.Domain.Common;

namespace HospitalManagement.Domain.Entities;

public class PatientRegisterationRequest : BaseEntity
{
    public string Email { get; set; }
    public string AccessCode { get; set; }
    public DateTime ExpiresOn { get; set; } 
}