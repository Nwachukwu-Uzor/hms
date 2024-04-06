using HospitalManagement.Domain.Common;

namespace HospitalManagement.Domain.Entities;

public class Doctor : BaseEntity
{
    public Staff StaffDetails { get; set; }
    public List<Appointment> Appointments { get; set; }
}
