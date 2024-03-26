using AutoMapper;
using HospitalManagement.Application.Contracts.Persistence;
using MediatR;

namespace HospitalManagement.Application.Features.Roles;

public class GetAllRolesQueryHandler : IRequestHandler<GetAllRolesQuery, List<RoleDto>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public GetAllRolesQueryHandler(IMapper mapper, IUnitOfWork unitOfWork)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }
    public async Task<List<RoleDto>> Handle(GetAllRolesQuery request, CancellationToken cancellationToken)
    {
        var roles = await _unitOfWork.RoleRepository.GetAllAsync();
        var rolesDto = _mapper.Map<List<RoleDto>>(roles);
        return rolesDto;
    }
}
