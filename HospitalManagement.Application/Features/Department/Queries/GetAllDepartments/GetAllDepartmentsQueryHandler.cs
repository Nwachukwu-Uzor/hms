using AutoMapper;
using HospitalManagement.Application.Contracts.Caching;
using HospitalManagement.Application.Contracts.Persistence;
using MediatR;

namespace HospitalManagement.Application.Features.Department;

public class GetAllDepartmentsQueryHandler : IRequestHandler<GetAllDepartmentsQuery, List<DepartmentDto>>
{
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;
    private readonly ICacheService _cacheService;

    public GetAllDepartmentsQueryHandler(IMapper mapper, IUnitOfWork unitOfWork, ICacheService cacheService)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
        _cacheService = cacheService;
    }

    public async Task<List<DepartmentDto>> Handle(GetAllDepartmentsQuery request, CancellationToken cancellationToken)
    {
        var departmentsFromCache = await _cacheService.GetRecordAsync<List<DepartmentDto>>("Departments");
        if (departmentsFromCache != null)
        {
            return departmentsFromCache;
        }
        var departments = await _unitOfWork.DepartmentRepository.GetAllAsync();
        var response = _mapper.Map<List<DepartmentDto>>(departments);
        await _cacheService.SetRecordAsync("Departments", response, TimeSpan.FromDays(1));
        return response;
    }
}
