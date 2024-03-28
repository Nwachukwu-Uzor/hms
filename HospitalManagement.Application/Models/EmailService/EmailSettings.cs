namespace HospitalManagement.Application.Models.EmailService;

public class EmailSettings
{
    public string From { get; set; }
    public string Username { get; set; }
    public string APIKey { get; set; } = Environment.GetEnvironmentVariable("HMS_SENDGRID_API_KEY") ?? "";
}
