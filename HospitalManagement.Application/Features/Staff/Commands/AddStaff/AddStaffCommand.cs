using HospitalManagement.Application.Features.Staff.Queries.GetStaffByStaffId;
using MediatR;

namespace HospitalManagement.Application.Features.Staff.Commands.AddStaff;

public class AddStaffCommand : IRequest<StaffDto>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string MiddleName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Address { get; set; }
    public Guid AppUserId { get; set; }
    public Guid DepartmentId { get; set; }
}

