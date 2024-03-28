using HospitalManagement.Application.Contracts.EmailService;
using HospitalManagement.Application.Models.EmailService;
using Microsoft.Extensions.Options;
using SendGrid.Helpers.Mail;
using SendGrid;

namespace HospitalManagement.Infrastructure.EmailService;

public class EmailSender : IEmailSender
{
    private readonly EmailSettings _emailSettings;

    public EmailSender(IOptions<EmailSettings> emailOptions)
    {
        _emailSettings = emailOptions.Value;
    }

    public async Task<bool> SendEmail(Email email)
    {
        try
        {
            var client = new SendGridClient(Environment.GetEnvironmentVariable(_emailSettings.APIKey));
            var from = new EmailAddress(_emailSettings.From, _emailSettings.Username);
            var subject = email.Subject;
            var to = new EmailAddress(email.To);
            var htmlContent = email.Body;
            var msg = MailHelper.CreateSingleEmail(from, to, subject, null, htmlContent);
            var response = await client.SendEmailAsync(msg);
            return true;
        } catch (Exception)
        {
            return false;
        }
    }
}
