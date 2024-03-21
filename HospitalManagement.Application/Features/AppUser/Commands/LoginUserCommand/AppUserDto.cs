using HospitalManagement.Application.Features.Roles.Queries.GetAllRolesQuery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Application.Features.AppUser.Commands.LoginUserCommand
{
    public class AppUserDto
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public List<RoleDto> Roles { get; set; }
    }
}
