using MediatR;

namespace HospitalManagement.Application.Features.Roles;

public record GetAllRolesQuery : IRequest<List<RoleDto>>;
