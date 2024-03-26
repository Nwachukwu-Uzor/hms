using MediatR;

namespace HospitalManagement.Application.Features.Department;

public record GetAllDepartmentsQuery : IRequest<List<DepartmentDto>>;
