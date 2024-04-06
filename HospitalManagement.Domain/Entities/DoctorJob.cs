using HospitalManagement.Domain.Common;

namespace HospitalManagement.Domain.Entities;

public class DoctorJob : BaseEntity
{
    public Guid JobId { get; set; }
    public Job Job { get; set; }
}
