﻿using HospitalManagement.API.Helpers;
using HospitalManagement.Application.Features.Patient;
using HospitalManagement.Application.Features.PatientRegisterationRequest;
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

    [HttpPost(nameof(PatientRegisterationRequest))]
    public async Task<IActionResult> PatientRegisterationRequest(CreatePatientRegisterationRequestCommand request)
    {
        var response = await _sender.Send(request);
        return Ok(APIResponseGenerator.GenerateEmptyResponse(true, $"Registeration link sent to {request.Email}"));
    }

    [HttpPost(nameof(VerifyPatientRegisterRequest))]
    public async Task<IActionResult> VerifyPatientRegisterRequest(VerifyPatientRegisterationRequestCommand request)
    {
        var response = await _sender.Send(request);
        return Ok(APIResponseGenerator.GenerateFailureResponse(response, "Email verified successfully"));
    }

    [HttpPost(nameof(CompletePatientDetails))]
    public async Task<IActionResult> CompletePatientDetails(CompletePatientDetailsCommand command)
    {
        var response = await _sender.Send(command);
        return Ok(APIResponseGenerator.GenerateSuccessResponse(response));
    }

    [HttpGet(nameof(GetPatientDetailsByPatientID) + "/{patientID}")]
    public async Task<IActionResult> GetPatientDetailsByPatientID(string patientID)
    {
        var response = await _sender.Send(new GetPatientByPatientIDQuery(patientID));
        return Ok(APIResponseGenerator.GenerateSuccessResponse(response));
    }
}
