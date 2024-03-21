using HospitalManagement.Application.Features.AppUser.Commands.CreateAdminUserCommand;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUserController : ControllerBase
    {
        private readonly IMediator _mediator;
        public AppUserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAdminUser(CreateAdminUserCommand command)
        {
            await _mediator.Send(command);
            return Ok();
        }
    }
}
