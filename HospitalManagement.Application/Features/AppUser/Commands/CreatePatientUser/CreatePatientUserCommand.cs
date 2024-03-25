using MediatR;

namespace HospitalManagement.Application.Features.AppUser.Commands.CreatePatientUser;

public class CreatePatientUserCommand : IRequest<Guid>
{
    public string Email { get; set; }
    public string Password { get; set; }
    public string ConfirmPassword { get; set; }
}
