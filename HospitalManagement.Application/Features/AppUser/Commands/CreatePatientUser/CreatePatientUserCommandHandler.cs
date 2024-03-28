using HospitalManagement.Application.Contracts.AuthService;
using HospitalManagement.Application.Contracts.EmailService;
using HospitalManagement.Application.Contracts.Logging;
using HospitalManagement.Application.Contracts.Persistence;
using HospitalManagement.Application.Exceptions;
using HospitalManagement.Application.Models.AuthService;
using HospitalManagement.Application.Models.EmailService;
using MediatR;
using Microsoft.Extensions.Options;

namespace HospitalManagement.Application.Features.AppUser
{
    public class CreatePatientUserCommandHandler : IRequestHandler<CreatePatientUserCommand, Guid>
    {
        private readonly IPasswordService _passwordManager;
        private readonly IRoleManager _roleManager;
        private readonly RolesId _rolesId;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IEmailSender _emailSender;
        private readonly IAppLogger<CreatePatientUserCommand> _logger;

        public CreatePatientUserCommandHandler(
        IPasswordService passwordManager,
        IRoleManager roleManager,
        IOptions<RolesId> option,
        IUnitOfWork unitOfWork,
        IEmailSender emailSender,
        IAppLogger<CreatePatientUserCommand> logger)
        {
            _passwordManager = passwordManager;
            _roleManager = roleManager;
            _rolesId = option.Value;
            _unitOfWork = unitOfWork;
            _emailSender = emailSender;
            _logger = logger;
        }
        public async Task<Guid> Handle(CreatePatientUserCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreatePatientUserCommandValidator(_unitOfWork);

            var validationResult = await validator.ValidateAsync(request);
            if (validationResult.Errors.Any())
            {
                throw new BadRequestException($"{nameof(Domain.Entities.AppUser)} returns validation errors", validationResult);
            }
            var passwordHash = _passwordManager.HashPassword(request.Password);
            var appUser = new Domain.Entities.AppUser()
            {
                Email = request.Email,
                Password = passwordHash.Hash,
                Salt = passwordHash.Salt
            };
            var user = await _unitOfWork.AppUserRepository.CreateAsync(appUser);
            await _unitOfWork.CompleteAsync();
            await _roleManager.AddUserToRole(appUser.Id, _rolesId.PatientRoleId);
            var welcomeEmail = new Email
            {
                Body = "<div>" +
                "<h3>Hello, </h3>" +
                "<p>Welcome to clinic, kindly click the link below to confirm your email</p>" +
                $"<a href='http://front-end-url/user/confirm/{user.Id}'>Confirm Email</a>" +
                "</div>"
            };
            var isEmailSent = await _emailSender.SendEmail(welcomeEmail);
            if (!isEmailSent)
            {
                _logger.LogWarning($"Unable to send email for patient user creating request with email ${request.Email}");
            }
            return user.Id;
        }
    }
}
