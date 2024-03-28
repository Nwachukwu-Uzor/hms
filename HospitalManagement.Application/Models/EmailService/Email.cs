namespace HospitalManagement.Application.Models.EmailService;

public record Email(string To, string Subject, string Body, string? From);
