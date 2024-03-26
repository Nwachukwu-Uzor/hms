using HospitalManagement.Domain.Common;

namespace HospitalManagement.Domain.Entities;

public class Job : BaseEntity
{
    public string Title { get; set; }
    public Guid DepartmentId { get; set; }
    public Department Department { get; set; }
}
