using AutoMapper;
using HospitalManagement.Application.Contracts.Persistence;
using HospitalManagement.Application.Exceptions;
using HospitalManagement.Application.Features.Patient.DTOs;
using MediatR;

namespace HospitalManagement.Application.Features.Patient;

public class GetPatientByPatientIDQueryHandler : IRequestHandler<GetPatientByPatientIDQuery, PatientDto>
{
    private readonly IPatientRepository _patientRepository;
    private readonly IMapper _mapper;

    public GetPatientByPatientIDQueryHandler(IPatientRepository patientRepository, IMapper mapper)
    {
        _patientRepository = patientRepository;
        _mapper = mapper;
    }

    public async Task<PatientDto> Handle(GetPatientByPatientIDQuery request, CancellationToken cancellationToken)
    {
        var patient = await _patientRepository.GetPatientByPatientID(request.PatientID);
        if (patient == null)
        {
            throw new NotFoundException(nameof(Domain.Entities.Patient), request.PatientID);
        }
        var response = _mapper.Map<PatientDto>(patient);
        return response;
    }
}
