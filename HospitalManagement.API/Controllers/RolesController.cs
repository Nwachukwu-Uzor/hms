using HospitalManagement.API.Helpers;
using HospitalManagement.Application.Features.Roles;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly IMediator _mediator;
        public RolesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllRoles()
        {
            var roles = await _mediator.Send(new GetAllRolesQuery());
            return Ok(APIResponseGenerator.GenerateSuccessResponse(roles));
        }
    }
}
