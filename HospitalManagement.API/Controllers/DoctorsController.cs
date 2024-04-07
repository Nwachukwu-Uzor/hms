using HospitalManagement.API.Helpers;
using HospitalManagement.Application.Features.Doctor;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        private readonly ISender _sender;

        public DoctorsController(ISender sender)
        {
            _sender = sender;
        }

        [HttpGet(nameof(GetAllDoctors))]
        public async Task<IActionResult> GetAllDoctors()
        {
            var doctors = await _sender.Send(new GetAllDoctorsQuery());
            return Ok(APIResponseGenerator.GenerateSuccessResponse(doctors, "Doctors retrieved successfully"));
        }
    }
}
