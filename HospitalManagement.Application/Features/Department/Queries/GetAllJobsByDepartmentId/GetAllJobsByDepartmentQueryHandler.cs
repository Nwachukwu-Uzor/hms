using AutoMapper;
using HospitalManagement.Application.Contracts.Caching;
using HospitalManagement.Application.Contracts.Persistence;
using HospitalManagement.Application.Features.Job.DTOs;
using MediatR;
using Microsoft.Extensions.Logging;

namespace HospitalManagement.Application.Features.Department;

public class GetAllJobsByDepartmentQueryHandler : IRequestHandler<GetAllJobsByDepartmentIdQuery, List<JobDto>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    private readonly ICacheService _cacheService;
    private readonly ILogger<GetAllJobsByDepartmentQueryHandler> _logger;
    public GetAllJobsByDepartmentQueryHandler(IMapper mapper, IUnitOfWork unitOfWork, ICacheService cacheService, ILogger<GetAllJobsByDepartmentQueryHandler> logger)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
        _cacheService = cacheService;
        _logger = logger;
    }

    public async Task<List<JobDto>> Handle(GetAllJobsByDepartmentIdQuery request, CancellationToken cancellationToken)
    {
        var CACHE_KEY = "GetAllJobsByDepartId_" + (request.DepartmentId.ToString() ?? "");
        var jobsFromCache = await _cacheService.GetRecordAsync<List<JobDto>>(CACHE_KEY);
        if (jobsFromCache != null)
        {
            _logger.LogInformation($"{nameof(Domain.Entities.Department)} with id {request.DepartmentId} retrieved from cache");
            return jobsFromCache;
        }
        var jobs = await _unitOfWork.JobRepository.GetAllJobsByDepartmentIdAsync(request.DepartmentId);
        var response = _mapper.Map<List<JobDto>>(jobs);
        await _cacheService.SetRecordAsync(CACHE_KEY, response, TimeSpan.FromHours(5), TimeSpan.FromMinutes(30));
        _logger.LogInformation($"{nameof(Domain.Entities.Job)} list for {nameof(Domain.Entities.Department)} with id {request.DepartmentId} retrieved from database");
        return response;
    }
}
