using MediatR;

namespace HospitalManagement.Application.Features.Staff;

public class AddStaffCommand : IRequest<StaffDto>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string MiddleName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Address { get; set; }
    public Guid AppUserId { get; set; }
    public Guid JobId { get; set; }
}

