using HospitalManagement.Domain.Common;

namespace HospitalManagement.Domain.Entities;

public class Job : BaseEntity
{
    public string Title { get; set; }
    public List<Department> Departments { get; set; }
}
