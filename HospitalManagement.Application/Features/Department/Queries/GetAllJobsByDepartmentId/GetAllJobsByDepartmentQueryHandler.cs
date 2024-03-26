using AutoMapper;
using HospitalManagement.Application.Contracts.Persistence;
using HospitalManagement.Application.Features.Job.DTOs;
using MediatR;

namespace HospitalManagement.Application.Features.Department;

public class GetAllJobsByDepartmentQueryHandler : IRequestHandler<GetAllJobsByDepartmentIdQuery, List<JobDto>>
{
    private readonly IJobRepository _jobRepository;
    private readonly IMapper _mapper;

    public GetAllJobsByDepartmentQueryHandler(IJobRepository jobRepository, IMapper mapper)
    {
        _jobRepository = jobRepository;
        _mapper = mapper;
    }

    public async Task<List<JobDto>> Handle(GetAllJobsByDepartmentIdQuery request, CancellationToken cancellationToken)
    {
        var jobs = await _jobRepository.GetAllJobsByDepartmentIdAsync(request.DepartmentId);
        var response = _mapper.Map<List<JobDto>>(jobs);
        return response;
    }
}
