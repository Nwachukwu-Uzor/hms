using AutoMapper;
using HospitalManagement.Application.Contracts.Persistence;
using HospitalManagement.Application.Exceptions;
using HospitalManagement.Application.Features.Patient.DTOs;
using MediatR;

namespace HospitalManagement.Application.Features.Patient;

public class GetPatientByAppUserIDQueryHandler : IRequestHandler<GetPatientByAppUserIDQuery, PatientDto>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetPatientByAppUserIDQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<PatientDto> Handle(GetPatientByAppUserIDQuery request, CancellationToken cancellationToken)
    {
        var validator = new GetPatientByAppUserIDQueryValidator();
        var validationResult = validator.Validate(request);
        if (validationResult.Errors.Any())
        {
            throw new BadRequestException(nameof(GetPatientByAppUserIDQueryHandler), validationResult);
        }
        var patient = await _unitOfWork.PatientRepository.GetPatientByAppUserID(request.AppUserID);
        var patientDto = _mapper.Map<PatientDto>(patient);
        return patientDto;
    }
}
