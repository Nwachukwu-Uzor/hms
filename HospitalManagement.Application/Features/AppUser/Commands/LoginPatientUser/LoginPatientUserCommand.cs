using HospitalManagement.Application.Models.AuthService;
using MediatR;

namespace HospitalManagement.Application.Features.AppUser.Commands.LoginPatientUser;

public class LoginPatientUserCommand : IRequest<TokenData>
{
    public string Email { get; set; }
    public string Password { get; set; }
}
