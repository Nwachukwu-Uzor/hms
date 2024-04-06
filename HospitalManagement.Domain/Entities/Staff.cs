using HospitalManagement.Domain.Common;

namespace HospitalManagement.Domain.Entities;

public class Staff : BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string MiddleName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public string Country { get; set; }
    public Guid AppUserId { get; set; }
    public AppUser AppUser { get; set; }
    public Job Job { get; set; }
    public string StaffID { get; set; }
}
