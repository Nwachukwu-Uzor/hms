using MediatR;

namespace HospitalManagement.Application.Features.Department;

public class GetAllDepartmentsQuery : IRequest<List<DepartmentDto>>
{
}
