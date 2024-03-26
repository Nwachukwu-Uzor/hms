using HospitalManagement.Application.Features.Job.DTOs;
using MediatR;

namespace HospitalManagement.Application.Features.Department;

public record GetAllJobsByDepartmentIdQuery(Guid DepartmentId) : IRequest<List<JobDto>>;
