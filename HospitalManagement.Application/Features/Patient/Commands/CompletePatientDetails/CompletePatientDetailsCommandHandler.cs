using AutoMapper;
using HospitalManagement.Application.Contracts.IDGenerator;
using HospitalManagement.Application.Contracts.Persistence;
using HospitalManagement.Application.Exceptions;
using HospitalManagement.Application.Features.Patient.DTOs;
using MediatR;

namespace HospitalManagement.Application.Features.Patient;

public class CompletePatientDetailsCommandHandler : IRequestHandler<CompletePatientDetailsCommand, PatientDto>
{
    private readonly IMapper _mapper;
    private readonly IAppUserRepository _appUserRepository;
    private readonly IIDGenerator _idGenerator;
    private readonly IUnitOfWork _unitOfWork;

    public CompletePatientDetailsCommandHandler(
        IMapper mapper,
        IAppUserRepository appUserRepository,
        IIDGenerator idGenerator,
        IUnitOfWork unitOfWork)
    {
        _mapper = mapper;
        _appUserRepository = appUserRepository;
        _idGenerator = idGenerator;
        _unitOfWork = unitOfWork;
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
        var patientForAppUserId = await _unitOfWork.PatientRepository.GetPatientByAppUserID(request.AppUserId);

        if (patientForAppUserId != null)
        {
            throw new BadRequestException($"{nameof(Domain.Entities.AppUser)} with key {request.AppUserId} is already mapped to a staff");
        }
        // END

        var patient = _mapper.Map<Domain.Entities.Patient>(request);
        patient.AppUser = appUser;
        var patientID = await _idGenerator.GeneratePatientIDNumber();
        patient.PatientID = patientID;
        var response = await _unitOfWork.PatientRepository.CreateAsync(patient);
        var data = _mapper.Map<PatientDto>(response);
        await _unitOfWork.CompleteAsync();
        return data;
    }
}
