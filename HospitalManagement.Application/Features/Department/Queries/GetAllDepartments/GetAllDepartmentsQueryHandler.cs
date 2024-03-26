using AutoMapper;
using HospitalManagement.Application.Contracts.Persistence;
using MediatR;

namespace HospitalManagement.Application.Features.Department;

public class GetAllDepartmentsQueryHandler : IRequestHandler<GetAllDepartmentsQuery, List<DepartmentDto>>
{
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;

    public GetAllDepartmentsQueryHandler(IMapper mapper, IUnitOfWork unitOfWork)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }

    public async Task<List<DepartmentDto>> Handle(GetAllDepartmentsQuery request, CancellationToken cancellationToken)
    {
        var departments = await _unitOfWork.DepartmentRepository.GetAllAsync();
        var response = _mapper.Map<List<DepartmentDto>>(departments);
        return response;
    }
}
