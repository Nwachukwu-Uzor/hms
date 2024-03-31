using HospitalManagement.Application.Contracts.EmailService;
using HospitalManagement.Application.Models.EmailService;
using Microsoft.Extensions.Options;
using SendGrid.Helpers.Mail;
using SendGrid;
using HospitalManagement.Application.Contracts.Logging;
using HospitalManagement.Application.Contracts;

namespace HospitalManagement.Infrastructure.EmailService;

public class EmailSender : IEmailSender
{
    private readonly EmailSettings _emailSettings;
    private readonly IAppLogger<EmailSender> _logger;
    private readonly IEncrytionService _encryptionService;

    public EmailSender(IOptions<EmailSettings> emailOptions, IAppLogger<EmailSender> logger, IEncrytionService encryptionService)
    {
        _emailSettings = emailOptions.Value;
        _logger = logger;
        _encryptionService = encryptionService;
    }

    public async Task<bool> SendEmail(Email email)
    {
        try
        {
            var apiKey = _encryptionService.Decrypt(_emailSettings.APIKey);
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress(_emailSettings.From, _emailSettings.Username);
            var subject = email.Subject;
            var to = new EmailAddress(email.To);
            var htmlContent = email.Body;
            var msg = MailHelper.CreateSingleEmail(from, to, subject, null, htmlContent);
            var response = await client.SendEmailAsync(msg);
            return true;
        } catch (Exception ex)
        {
            _logger.LogWarning(ex.Message, ex);
            return false;
        }
    }
}
