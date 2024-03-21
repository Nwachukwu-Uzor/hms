using HospitalManagement.Domain.Common;

namespace HospitalManagement.Domain.Entities;

public class Role : BaseEntity
{
    public string Name { get; set; }
    public List<AppUser> Users { get; set; }
}
