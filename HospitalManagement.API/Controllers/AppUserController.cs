using HospitalManagement.API.Helpers;
using HospitalManagement.Application.Features.AppUser.Commands.CreatePatientUser;
using HospitalManagement.Application.Features.AppUser.Commands.CreateStaffUser;
using HospitalManagement.Application.Features.AppUser.Commands.LoginAdminUser;
using HospitalManagement.Application.Features.AppUser.Commands.LoginPatientUser;
using HospitalManagement.Application.Features.AppUser.Commands.MakeStaffAdminUser;
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

        [HttpPost(nameof(CreateStaffUser))]
        public async Task<IActionResult> CreateStaffUser(CreateStaffUserCommand command)
        {
            var response = await _mediator.Send(command);
            return Ok(APIResponseGenerator.GenerateEmptyResponse(true, response));
        }
        
        [HttpPost(nameof(CreatePatientUser))]
        public async Task<IActionResult> CreatePatientUser(CreatePatientUserCommand command)
        {
            var response = await _mediator.Send(command);
            return Ok(APIResponseGenerator.GenerateEmptyResponse(true, response));
        }

        [HttpPost($"{nameof(LoginAdminUser)}")]
        public async Task<IActionResult> LoginAdminUser(LoginAdminUserCommand command)
        {
            var response = await _mediator.Send(command);
            return Ok(APIResponseGenerator.GenerateSuceessResponse(response, "Login successful"));
        }
        
        [HttpPost($"{nameof(LoginPatientUser)}")]
        public async Task<IActionResult> LoginPatientUser(LoginPatientUserCommand command)
        {
            var response = await _mediator.Send(command);
            return Ok(APIResponseGenerator.GenerateSuceessResponse(response, "Login successful"));
        }

        [HttpPut(nameof(MakeStaffAdminUser))]
        public async Task<IActionResult> MakeStaffAdminUser(MakeStaffAdminUserCommand command)
        {
            var response = await _mediator.Send(command);
            return Ok(APIResponseGenerator.GenerateSuceessResponse(response, "Staff role updated successfully"));
        }
    }
}   
