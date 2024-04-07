using HospitalManagement.API.Helpers;
using HospitalManagement.Application.Features.Appointment;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentsController : ControllerBase
    {
        private readonly ISender _sender;
        public AppointmentsController(ISender sender)
        {
            _sender = sender;
        }

        [HttpPost(nameof(CreateAppointment))]
        public async Task<IActionResult> CreateAppointment(CreateAppointmentCommand command)
        {
            var response = await _sender.Send(command);
            return Ok(APIResponseGenerator.GenerateSuccessResponse(response, "Appointment created successfully"));
        }
    }
}
