using MediatR;

namespace HospitalManagement.Application.Features.Department;

public record CreateNewDepartmentCommand(string Name) : IRequest<DepartmentDto>;
