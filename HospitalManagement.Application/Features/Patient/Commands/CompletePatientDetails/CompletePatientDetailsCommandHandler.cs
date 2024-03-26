using AutoMapper;
using HospitalManagement.Application.Contracts.IDGenerator;
using HospitalManagement.Application.Contracts.Persistence;
using HospitalManagement.Application.Exceptions;
using HospitalManagement.Application.Features.Patient.DTOs;
using MediatR;

namespace HospitalManagement.Application.Features.Patient.Commands.CompletePatientDetails;

public class CompletePatientDetailsCommandHandler : IRequestHandler<CompletePatientDetailsCommand, PatientDto>
{
    private readonly IMapper _mapper;
    private readonly IPatientRepository _patientRepository;
    private readonly IJobRepository _departmentRepository;
    private readonly IAppUserRepository _appUserRepository;
    private readonly IIDGenerator _idGenerator;

    public CompletePatientDetailsCommandHandler(
        IMapper mapper,
        IPatientRepository patientRepository,
        IJobRepository departmentRepository,
        IAppUserRepository appUserRepository,
        IIDGenerator idGenerator
    )
    {
        _mapper = mapper;
        _patientRepository = patientRepository;
        _departmentRepository = departmentRepository;
        _appUserRepository = appUserRepository;
        _idGenerator = idGenerator;
    }
    public async Task<PatientDto> Handle(CompletePatientDetailsCommand request, CancellationToken cancellationToken)
    {
        var validator = new CompletePatientDetailsCommandValidator();
        var validationResult = validator.Validate(request);
        if (validationResult.Errors.Any())
        {
            throw new BadRequestException($"{nameof(Domain.Entities.Staff)} returns validation errors", validationResult);
        }

        var appUser = await _appUserRepository.GetByIdAsync(request.AppUserId);

        if (appUser == null)
        {
            throw new NotFoundException(nameof(Domain.Entities.AppUser), request.AppUserId);
        }

        // START: Handles when the app user is already assigned to a staff
        var patientForAppUserId = await _patientRepository.GetPatientByAppUserID(request.AppUserId);

        if (patientForAppUserId != null)
        {
            throw new BadRequestException($"{nameof(Domain.Entities.AppUser)} with key {request.AppUserId} is already mapped to a staff");
        }
        // END

        var patient = _mapper.Map<Domain.Entities.Patient>(request);
        patient.AppUser = appUser;
        var patientID = await _idGenerator.GeneratePatientIDNumber();
        patient.PatientID = patientID;
        var response = await _patientRepository.CreateAsync(patient);
        var data = _mapper.Map<PatientDto>(response);
        return data;
    }
}
