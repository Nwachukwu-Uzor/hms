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

        [HttpPost(nameof(OnboardStaff))]
        public async Task<IActionResult> OnboardStaff(OnboardStaffCommand command)
        {
            var response = await _sender.Send(command);
            return Ok(APIResponseGenerator.GenerateSuccessResponse(response, "Staff onboarded successfully"));
        }

        [HttpGet($"{nameof(GetStaffByStaffId)}" + "/{staffId}")]
        public async Task<IActionResult> GetStaffByStaffId(string staffId)
        {
            var response = await _sender.Send(new GetStaffByStaffIdQuery(staffId));
            return Ok(APIResponseGenerator.GenerateSuccessResponse(response, "Staff details retrieved successfully"));
        }

        [HttpGet(nameof(GetStaffPaginated))]
        public async Task<IActionResult> GetStaffPaginated(int page, int pageSize)
        {
            var response = await _sender.Send(new GetStaffPaginatedQuery(page, pageSize));
            return Ok(
                APIResponseGenerator.GenerateSuccessResponse(
                    response,
                    response.Data.Count > 0 ? "Staff retrieved successfully" : "No records found"
                )
            );
        }

        
    }
}
