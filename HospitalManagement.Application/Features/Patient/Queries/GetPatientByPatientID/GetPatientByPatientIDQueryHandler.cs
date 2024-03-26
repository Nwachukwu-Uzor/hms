using AutoMapper;
using HospitalManagement.Application.Contracts.Persistence;
using HospitalManagement.Application.Exceptions;
using HospitalManagement.Application.Features.Patient.DTOs;
using MediatR;

namespace HospitalManagement.Application.Features.Patient;

public class GetPatientByPatientIDQueryHandler : IRequestHandler<GetPatientByPatientIDQuery, PatientDto>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetPatientByPatientIDQueryHandler(IMapper mapper, IUnitOfWork unitOfWork)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }

    public async Task<PatientDto> Handle(GetPatientByPatientIDQuery request, CancellationToken cancellationToken)
    {
        var patient = await _unitOfWork.PatientRepository.GetPatientByPatientID(request.PatientID);
        if (patient == null)
        {
            throw new NotFoundException(nameof(Domain.Entities.Patient), request.PatientID);
        }
        var response = _mapper.Map<PatientDto>(patient);
        return response;
    }
}
