using MediatR;

namespace HospitalManagement.Application.Features.AppUser.Commands.LoginUserCommand;

public class LoginUserCommand : IRequest<string>
{
    public string Email { get; set; }
    public string Password { get; set; }
}
