using HospitalManagement.Application.Features.Department;

namespace HospitalManagement.Application.Features.Job.DTOs;

public class JobDto
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public DepartmentDto Department { get; set; }
}
