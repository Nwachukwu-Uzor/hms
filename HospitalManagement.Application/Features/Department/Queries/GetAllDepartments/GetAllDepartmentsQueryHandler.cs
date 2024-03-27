using AutoMapper;
using HospitalManagement.Application.Contracts.Caching;
using HospitalManagement.Application.Contracts.Persistence;
using MediatR;
using Microsoft.Extensions.Logging;

namespace HospitalManagement.Application.Features.Department;

public class GetAllDepartmentsQueryHandler : IRequestHandler<GetAllDepartmentsQuery, List<DepartmentDto>>
{
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;
    private readonly ICacheService _cacheService;
    private readonly ILogger<GetAllDepartmentsQueryHandler> _logger;

    public GetAllDepartmentsQueryHandler(
        IMapper mapper, 
        IUnitOfWork unitOfWork, 
        ICacheService cacheService, 
        ILogger<GetAllDepartmentsQueryHandler> logger
    )
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
        _cacheService = cacheService;
        _logger = logger;
    }

    public async Task<List<DepartmentDto>> Handle(GetAllDepartmentsQuery request, CancellationToken cancellationToken)
    {
        var departmentsFromCache = await _cacheService.GetRecordAsync<List<DepartmentDto>>("Departments");
        if (departmentsFromCache != null)
        {
            _logger.LogInformation($"{nameof(Domain.Entities.Department)} list retrieved from cache");
            return departmentsFromCache;
        }
        var departments = await _unitOfWork.DepartmentRepository.GetAllAsync();
        var response = _mapper.Map<List<DepartmentDto>>(departments);
        await _cacheService.SetRecordAsync("Departments", response, TimeSpan.FromDays(1)); 
        _logger.LogInformation($"{nameof(Domain.Entities.Department)} list retrieved from database");
        return response;
    }
}
