using AutoMapper;
using HospitalManagement.Application.Contracts.Persistence;
using MediatR;

namespace HospitalManagement.Application.Features.Roles;

public class GetAllRolesQueryHandler : IRequestHandler<GetAllRolesQuery, List<RoleDto>>
{
    private readonly IRoleRepository _roleRepository;
    private readonly IMapper _mapper;
    public GetAllRolesQueryHandler(IRoleRepository roleRepository, IMapper mapper)
    {
        _roleRepository = roleRepository;
        _mapper = mapper;
    }
    public async Task<List<RoleDto>> Handle(GetAllRolesQuery request, CancellationToken cancellationToken)
    {
        var roles = await _roleRepository.GetAllAsync();
        var rolesDto = _mapper.Map<List<RoleDto>>(roles);
        return rolesDto;
    }
}
