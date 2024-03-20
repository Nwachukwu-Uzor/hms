using MediatR;

namespace HospitalManagement.Application.Features.AppUser.Commands.CreateAdminUserCommand;

public record CreateAdminUserCommand : IRequest<Unit>
{
    public string Email { get; set; }
    public string Password { get; set; }
    public string ConfirmPassword { get; set; }
}
