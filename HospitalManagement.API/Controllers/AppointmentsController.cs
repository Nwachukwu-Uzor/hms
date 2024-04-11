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

        [HttpGet(nameof(GetUpcomingAppointmentsPaginated))]
        public async Task<IActionResult> GetUpcomingAppointmentsPaginated(int page, int pageSize)
        {
            var query = new GetAllUpcomingAppointmentsPaginatedQuery(page, pageSize);
            var response = await _sender.Send(query);
            var message = response.Data.Count > 0 ? "Appointment retrieved successfully" : "No upcoming appointments";
            return Ok(APIResponseGenerator.GenerateSuccessResponse(response, message));
        }
        
        [HttpPost(nameof(GetAppointmentsByPatientIdPaginated))]
        public async Task<IActionResult> GetAppointmentsByPatientIdPaginated(GetAppointmentsByPatientIdPaginatedQuery query)
        {
            var response = await _sender.Send(query);
            var message = response.Data.Count > 0 ? "Appointment retrieved successfully" : "No appointments found";
            return Ok(APIResponseGenerator.GenerateSuccessResponse(response, message));
        }

        [HttpPost(nameof(GetAppointmentsByPatientAppUserIdPaginated))]
        public async Task<IActionResult> GetAppointmentsByPatientAppUserIdPaginated(GetAppointmentsByPatientAppUserIdPaginatedQuery query)
        {
            var response = await _sender.Send(query);
            var message = response.Data.Count > 0 ? "Appointment retrieved successfully" : "No appointments found";
            return Ok(APIResponseGenerator.GenerateSuccessResponse(response, message));
        }
    }
}
