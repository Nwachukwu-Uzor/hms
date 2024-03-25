using MediatR;

namespace HospitalManagement.Application.Features.Department.Queries.GetAllDepartmentsQuery;

public class GetAllDepartmentsQuery : IRequest<List<DepartmentDto>>
{
}
