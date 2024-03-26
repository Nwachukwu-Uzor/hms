using HospitalManagement.Application.Features.Roles;

namespace HospitalManagement.Application.Features.AppUser;

public class AppUserDto
{
    public Guid Id { get; set; }
    public string Email { get; set; }
    public List<RoleDto> Roles { get; set; }
}
