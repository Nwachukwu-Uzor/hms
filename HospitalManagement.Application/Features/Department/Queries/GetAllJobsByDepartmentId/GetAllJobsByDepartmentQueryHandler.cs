using AutoMapper;
using HospitalManagement.Application.Contracts.Persistence;
using HospitalManagement.Application.Features.Job.DTOs;
using MediatR;

namespace HospitalManagement.Application.Features.Department;

public class GetAllJobsByDepartmentQueryHandler : IRequestHandler<GetAllJobsByDepartmentIdQuery, List<JobDto>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetAllJobsByDepartmentQueryHandler(IMapper mapper, IUnitOfWork unitOfWork)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }

    public async Task<List<JobDto>> Handle(GetAllJobsByDepartmentIdQuery request, CancellationToken cancellationToken)
    {
        var jobs = await _unitOfWork.JobRepository.GetAllJobsByDepartmentIdAsync(request.DepartmentId);
        var response = _mapper.Map<List<JobDto>>(jobs);
        return response;
    }
}
