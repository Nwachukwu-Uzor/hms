using HospitalManagement.Domain.Common;
using HospitalManagement.Domain.Enums;

namespace HospitalManagement.Domain.Entities;

public class Appointment : BaseEntity
{
    public Guid DoctorId { get; set; }
    public Doctor Doctor { get; set; }
    public DateTime AppointmentTime { get; set; }
    public string Description { get; set; } = string.Empty;
    public Guid PatientId { get; set; }
    public Patient Patient { get; set; }
    public AppointmentStatus Status { get; set; } = AppointmentStatus.PENDING;
}
