using HospitalManagement.API.Helpers;
using HospitalManagement.Application.Features.Staff;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private readonly ISender _sender;

        public StaffController(ISender sender)
        {
            _sender = sender;
        }

        [HttpPost(nameof(AddStaff))]
        public async Task<IActionResult> AddStaff(AddStaffCommand request)
        {
            var response = await _sender.Send(request);
            return Ok(APIResponseGenerator.GenerateSuccessResponse(response));
        }

        [HttpGet($"{nameof(GetStaffByStaffId)}" + "/{staffId}")]
        public async Task<IActionResult> GetStaffByStaffId(string staffId)
        {
            var response = await _sender.Send(new GetStaffByStaffIdQuery(staffId));
            return Ok(response);
        }
    }
}
