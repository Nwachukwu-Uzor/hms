using HospitalManagement.API.Helpers;
using HospitalManagement.Application.Features.Patient.Commands.CompletePatientDetails;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManagement.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PatientsController : ControllerBase
{
    private readonly ISender _sender;

    public PatientsController(ISender sender)
    {
        _sender = sender;
    }

    [HttpPost(nameof(CompletePatientDetails))]
    public async Task<IActionResult> CompletePatientDetails(CompletePatientDetailsCommand command)
    {
        var response = await _sender.Send(command);
        return Ok(APIResponseGenerator.GenerateSuceessResponse(response));
    }
}
