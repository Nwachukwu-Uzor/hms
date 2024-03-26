using AutoMapper;
using HospitalManagement.Application.Contracts.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Application.Features.Department
{
    public class GetAllDepartmentsQueryHandler : IRequestHandler<GetAllDepartmentsQuery, List<DepartmentDto>>
    {
        private readonly IJobRepository _departmentRepository;
        private readonly IMapper _mapper;

        public GetAllDepartmentsQueryHandler(IJobRepository departmentRepository, IMapper mapper)
        {
            _departmentRepository = departmentRepository;
            _mapper = mapper;
        }

        public async Task<List<DepartmentDto>> Handle(GetAllDepartmentsQuery request, CancellationToken cancellationToken)
        {
            var departments = await _departmentRepository.GetAllAsync();
            var response = _mapper.Map<List<DepartmentDto>>(departments);
            return response;
        }
    }
}
