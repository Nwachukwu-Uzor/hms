using MediatR;

namespace HospitalManagement.Application.Features.Roles.Queries.GetAllRolesQuery;

public record GetAllRolesQuery : IRequest<List<RoleDto>>;
