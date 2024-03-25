using MediatR;

namespace HospitalManagement.Application.Features.AppUser.Commands.CreateStaffUser;

public record CreateStaffUserCommand : IRequest<Guid>
{
    public string Email { get; set; }
    public string Password { get; set; }
    public string ConfirmPassword { get; set; }
}
