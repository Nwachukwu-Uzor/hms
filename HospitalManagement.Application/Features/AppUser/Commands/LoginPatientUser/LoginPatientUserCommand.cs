using HospitalManagement.Application.Models.AuthService;
using MediatR;

namespace HospitalManagement.Application.Features.AppUser;

public class LoginPatientUserCommand : IRequest<TokenData>
{
    public string Email { get; set; }
    public string Password { get; set; }
}
