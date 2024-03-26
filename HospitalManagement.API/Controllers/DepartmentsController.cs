using HospitalManagement.API.Helpers;
using HospitalManagement.Application.Features.Department;
using HospitalManagement.Application.Features.Department.Queries.GetAllDepartmentsQuery;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly ISender _sender;

        public DepartmentsController(ISender sender)
        {
            _sender = sender;
        }

        [HttpGet(nameof(GetAll))]
        public async Task<IActionResult> GetAll()
        {
            var response = await _sender.Send(new GetAllDepartmentsQuery());
            return Ok(APIResponseGenerator.GenerateSuccessResponse(response));
        }

        [HttpGet(nameof(GetAllJobsByDepartmentId) + "/{departmentId:Guid}")]
        public async Task<IActionResult> GetAllJobsByDepartmentId(Guid departmentId)
        {
            var response = await _sender.Send(new GetAllJobsByDepartmentIdQuery(departmentId));
            return Ok(APIResponseGenerator.GenerateSuccessResponse(response));
        }
    }
}
