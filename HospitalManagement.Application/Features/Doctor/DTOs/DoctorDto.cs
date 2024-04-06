using HospitalManagement.Application.Features.Staff;

namespace HospitalManagement.Application.Features.Doctor.DTOs;

public class DoctorDto
{
    public Guid Id { get; set; }
    public StaffDto Staff { get; set; }
    public string StaffId { get; set; }
}
