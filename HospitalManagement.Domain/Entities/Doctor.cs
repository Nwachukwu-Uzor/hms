using HospitalManagement.Domain.Common;

namespace HospitalManagement.Domain.Entities;

public class Doctor : BaseEntity
{
    public Guid StaffId { get; set; }
    public Staff Staff { get; set; }
    public List<Appointment> Appointments { get; set; }
}
