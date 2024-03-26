using HospitalManagement.Application.Features.AppUser;
using HospitalManagement.Application.Features.Job.DTOs;

namespace HospitalManagement.Application.Features.Staff;

public class StaffDto
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string MiddleName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Address { get; set; }
    public AppUserDto AppUser { get; set; }
    public JobDto Job { get; set; }
    // public Job Job { get; set; }
    public string StaffID { get; set; }
}
