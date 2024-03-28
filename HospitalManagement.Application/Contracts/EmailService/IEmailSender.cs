using HospitalManagement.Application.Models.EmailService;

namespace HospitalManagement.Application.Contracts.EmailService;

public interface IEmailSender
{
    Task<bool> SendEmail(Email email);
}
