using HospitalManagement.API.Helpers;
using HospitalManagement.Application.Features.AppUser;
using MediatR;
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

        [HttpPost(nameof(CreateStaffUser))]
        public async Task<IActionResult> CreateStaffUser(CreateStaffUserCommand command)
        {
            var response = await _mediator.Send(command);
            return Ok(APIResponseGenerator.GenerateSuccessResponse(response));
        }
        
        [HttpPost(nameof(CreatePatientUser))]
        public async Task<IActionResult> CreatePatientUser(CreatePatientUserCommand command)
        {
            var response = await _mediator.Send(command);
            return Ok(APIResponseGenerator.GenerateSuccessResponse(response));
        }

        [HttpPost($"{nameof(LoginStaffUser)}")]
        public async Task<IActionResult> LoginStaffUser(LoginStaffUserCommand command)
        {
            var response = await _mediator.Send(command);
            return Ok(APIResponseGenerator.GenerateSuccessResponse(response, "Login successful"));
        }
        
        [HttpPost($"{nameof(LoginPatientUser)}")]
        public async Task<IActionResult> LoginPatientUser(LoginPatientUserCommand command)
        {
            var response = await _mediator.Send(command);
            return Ok(APIResponseGenerator.GenerateSuccessResponse(response, "Login successful"));
        }

        [HttpPut(nameof(MakeStaffAdminUser))]
        public async Task<IActionResult> MakeStaffAdminUser(MakeStaffAdminUserCommand command)
        {
            var response = await _mediator.Send(command);
            return Ok(APIResponseGenerator.GenerateSuccessResponse(response, "Staff role updated successfully"));
        }
    }
}   
