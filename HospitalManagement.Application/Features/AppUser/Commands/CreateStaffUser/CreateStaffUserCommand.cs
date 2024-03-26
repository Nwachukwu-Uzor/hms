using MediatR;

namespace HospitalManagement.Application.Features.AppUser;

public record CreateStaffUserCommand : IRequest<Guid>
{
    public string Email { get; set; }
    public string Password { get; set; }
    public string ConfirmPassword { get; set; }
}
