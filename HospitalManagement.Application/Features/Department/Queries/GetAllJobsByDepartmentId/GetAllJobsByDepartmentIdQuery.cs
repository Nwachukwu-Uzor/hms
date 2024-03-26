using HospitalManagement.Application.Features.Job.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Application.Features.Department;

public record GetAllJobsByDepartmentIdQuery(Guid DepartmentId) : IRequest<List<JobDto>>;
