namespace HospitalManagement.Application.Features;

public class PatientRegisterationRequestDTO
{
    public DateTime DateCreated { get; set; }
    public Guid Id { get; set; }
    public string Email { get; set; }
    public string AccessCode { get; set; }

    public DateTime ExpiresOn { get; set; } = DateTime.UtcNow.AddMinutes(60);
    public string VerificationStatus { get; set; }
}
