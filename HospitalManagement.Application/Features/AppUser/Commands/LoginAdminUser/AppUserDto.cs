using HospitalManagement.Application.Features.Roles.Queries.GetAllRolesQuery;

namespace HospitalManagement.Application.Features.AppUser.Commands.LoginAdminUser
{
    public class AppUserDto
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public List<RoleDto> Roles { get; set; }
    }
}
