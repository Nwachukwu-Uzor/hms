using AutoMapper;
using HospitalManagement.Application.Contracts.Caching;
using HospitalManagement.Application.Contracts.Persistence;
using HospitalManagement.Application.Features.Job.DTOs;
using MediatR;

namespace HospitalManagement.Application.Features.Department;

public class GetAllJobsByDepartmentQueryHandler : IRequestHandler<GetAllJobsByDepartmentIdQuery, List<JobDto>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    private readonly ICacheService _cacheService;

    public GetAllJobsByDepartmentQueryHandler(IMapper mapper, IUnitOfWork unitOfWork, ICacheService cacheService)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
        _cacheService = cacheService;
    }

    public async Task<List<JobDto>> Handle(GetAllJobsByDepartmentIdQuery request, CancellationToken cancellationToken)
    {
        var CACHE_KEY = "GetAllJobsByDepartId_" + (request.DepartmentId.ToString() ?? "");
        var jobsFromCache = await _cacheService.GetRecordAsync<List<JobDto>>(CACHE_KEY);
        if (jobsFromCache != null)
        {
            return jobsFromCache;
        }
        var jobs = await _unitOfWork.JobRepository.GetAllJobsByDepartmentIdAsync(request.DepartmentId);
        var response = _mapper.Map<List<JobDto>>(jobs);
        await _cacheService.SetRecordAsync(CACHE_KEY, response, TimeSpan.FromHours(5), TimeSpan.FromMinutes(30));
        return response;
    }
}
