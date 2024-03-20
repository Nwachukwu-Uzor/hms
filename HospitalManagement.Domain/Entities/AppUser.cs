using HospitalManagement.Domain.Common;

namespace HospitalManagement.Domain.Entities;

public class AppUser : BaseEntity
{
    public string Email { get; set; }
    public string Password { get; set; }
    public List<Role> Roles { get; set; }
    public string Salt { get; set; }
}
