using HospitalManagement.API.Helpers;
using HospitalManagement.Application.Contracts.AuthService;
using HospitalManagement.Application.Features.Patient;
using HospitalManagement.Application.Features.PatientRegisterationRequest;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManagement.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PatientsController : ControllerBase
{
    private readonly ISender _sender;
    private readonly IJwtTokenService _jwtService;

    public PatientsController(ISender sender, IJwtTokenService jwtService)
    {
        _sender = sender;
        _jwtService = jwtService;
    }

    private Guid GetUserId()
    {
        if (HttpContext.Items.TryGetValue("Token", out var token))
        {
            string extractedToken = token.ToString();

            // Your logic to validate or process the token
            var decodedToken = _jwtService.DecodeToken(extractedToken);
            var claim = decodedToken.Claims.FirstOrDefault(c => c.Type == "Id" );
            return Guid.Parse(claim.Value);
        }

        return default;
    }

    [HttpPost(nameof(PatientRegisterationRequest))]
    public async Task<IActionResult> PatientRegisterationRequest(CreatePatientRegisterationRequestCommand request)
    {
        await _sender.Send(request);
        return Ok(APIResponseGenerator.GenerateEmptyResponse(true, $"Registeration link sent to {request.Email}"));
    }

    [HttpPost(nameof(VerifyPatientRegisterRequest))]
    public async Task<IActionResult> VerifyPatientRegisterRequest(VerifyPatientRegisterationRequestCommand request)
    {
        var response = await _sender.Send(request);
        return Ok(APIResponseGenerator.GenerateSuccessResponse(response, "Email verified successfully"));
    }

    [HttpPost(nameof(CreatePatientPassword))]
    public async Task<IActionResult> CreatePatientPassword(CreatePatientPasswordCommand request)
    {
        var response = await _sender.Send(request);
        return Ok(APIResponseGenerator.GenerateSuccessResponse(response, "Password created successfully"));
    }

    [Authorize]
    [HttpPost(nameof(CompletePatientDetails))]
    public async Task<IActionResult> CompletePatientDetails(CompletePatientDetailsCommand command)
    {
       
        var response = await _sender.Send(command);
        return Ok(APIResponseGenerator.GenerateSuccessResponse(response, "Profile retrieved successfully"));
    } 
    
    // [Authorize]
    [HttpGet(nameof(GetPatientsPaginated))]
    public async Task<IActionResult> GetPatientsPaginated(int page, int pageSize=30)
    {
       
        var response = await _sender.Send(new GetPatientsPaginatedQuery(page, pageSize));
        return Ok(APIResponseGenerator.GenerateSuccessResponse(response, "Patients retrieved successfully"));
    }

    [HttpGet(nameof(GetPatientDetailsByPatientID) + "/{patientID}")]
    public async Task<IActionResult> GetPatientDetailsByPatientID(string patientID)
    {
        var response = await _sender.Send(new GetPatientByPatientIDQuery(patientID));
        return Ok(APIResponseGenerator.GenerateSuccessResponse(response));
    }

    [Authorize]
    [HttpGet(nameof(GetPatientDetailsByAppUserID))]
    public async Task<IActionResult> GetPatientDetailsByAppUserID()
    {
        var userId = GetUserId();
        var response = await _sender.Send(new GetPatientByAppUserIDQuery(userId));
        var message = response == null ? "No patient record found" : "Patient record retrieved successfully.";
        return Ok(APIResponseGenerator.GenerateSuccessResponse(response, message));
    }
}
