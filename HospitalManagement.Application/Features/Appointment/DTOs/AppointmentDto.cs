using HospitalManagement.Application.Features.Doctor.DTOs;
using HospitalManagement.Application.Features.Patient.DTOs;
using HospitalManagement.Domain.Enums;

namespace HospitalManagement.Application.Features.Appointment.DTOs;

public class AppointmentDto
{
    public Guid DoctorId { get; set; }
    public DoctorDto Doctor { get; set; }
    public DateTime AppointmentTime { get; set; }
    public string Description { get; set; } = string.Empty;
    public Guid PatientId { get; set; }
    public PatientDto Patient { get; set; }
    public string Status { get; set; }
}
