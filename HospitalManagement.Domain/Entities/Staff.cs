using HospitalManagement.Domain.Common;

namespace HospitalManagement.Domain.Entities;

public class Staff : BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string MiddleName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Address { get; set; }
    public AppUser AppUser { get; set; }
    public Department Department { get; set; }
}
