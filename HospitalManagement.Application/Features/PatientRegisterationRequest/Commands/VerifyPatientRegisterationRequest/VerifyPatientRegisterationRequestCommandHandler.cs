using AutoMapper;
using HospitalManagement.Application.Contracts.Logging;
using HospitalManagement.Application.Contracts.Persistence;
using HospitalManagement.Application.Exceptions;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Application.Features.PatientRegisterationRequest;

public class VerifyPatientRegisterationRequestCommandHandler : IRequestHandler<VerifyPatientRegisterationRequestCommand, PatientRegisterationRequestDTO>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IAppLogger<VerifyPatientRegisterationRequestCommandHandler> _logger;
    private readonly IMapper _mapper;

    public VerifyPatientRegisterationRequestCommandHandler(
        IAppLogger<VerifyPatientRegisterationRequestCommandHandler> logger,
        IUnitOfWork unitOfWork,
        IMapper mapper)
    {
        _logger = logger;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<PatientRegisterationRequestDTO> Handle(VerifyPatientRegisterationRequestCommand request, CancellationToken cancellationToken)
    {
        var validator = new VerifyPatientRegisterationRequestCommandValidator();
        var validationResult = validator.Validate(request);
        if (validationResult.Errors.Any())
        {
            throw new BadRequestException($"{nameof(VerifyPatientRegisterationRequestCommandHandler)}", validationResult);
        }
        var patientRequest = await _unitOfWork.PatientRegisterationRequestRepository
            .GetPatientRegisterRequestByIdAndAccessCode(request.Id, request.AccessCode);
        if (patientRequest is null)
        {
            _logger.LogWarning(
                $"Invalid verification link with AccessCode={request.AccessCode} and Id={request.Id} was provided"
            );
            throw new BadRequestException("Invalid verification link");
        }

        if (patientRequest.ExpiresOn <  DateTime.UtcNow && patientRequest.VerificationStatus != Domain.Enums.PatientRequestVerificationStatus.VERIFIED)
        {
            _logger.LogWarning(
               $"Expired verification link with AccessCode={request.AccessCode} and Id={request.Id} was provided"
            );
            throw new BadRequestException("Verification link has expired, please generate a new one");
        }

        if (patientRequest.VerificationStatus != Domain.Enums.PatientRequestVerificationStatus.VERIFIED)
        {
            patientRequest.VerificationStatus = Domain.Enums.PatientRequestVerificationStatus.VERIFIED;
            _unitOfWork.PatientRegisterationRequestRepository.UpdateAsync(patientRequest);
            await _unitOfWork.CompleteAsync();
        }

        var response = _mapper.Map<PatientRegisterationRequestDTO>(patientRequest);
        return response;
    }
}
