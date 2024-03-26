using AutoMapper;
using HospitalManagement.Application.Contracts.IDGenerator;
using HospitalManagement.Application.Contracts.Persistence;
using HospitalManagement.Application.Exceptions;
using HospitalManagement.Application.Features.Staff.Queries.GetStaffByStaffId;
using MediatR;

namespace HospitalManagement.Application.Features.Staff.Commands.AddStaff;

public class CompletePatientDetailsCommandHandler : IRequestHandler<AddStaffCommand, StaffDto>
{
    private readonly IMapper _mapper;
    private readonly IStaffRepository _staffRepository;
    private readonly IJobRepository _jobRepository;
    private readonly IAppUserRepository _appUserRepository;
    private readonly IIDGenerator _idGenerator;

    public CompletePatientDetailsCommandHandler(
        IMapper mapper,
        IStaffRepository staffRepository,
        IJobRepository jobRepository,
        IAppUserRepository appUserRepository,
        IIDGenerator idGenerator
    )
    {
        _mapper = mapper;
        _staffRepository = staffRepository;
        _jobRepository = jobRepository;
        _appUserRepository = appUserRepository;
        _idGenerator = idGenerator;
    }
    public async Task<StaffDto> Handle(AddStaffCommand request, CancellationToken cancellationToken)
    {
        var validator = new AddStaffCommandValidator();
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

        var job = await _jobRepository.GetByIdAsync(request.JobId);

        if (job == null)
        {
            throw new NotFoundException(nameof(Domain.Entities.Job), request.JobId);
        }

        // START: Handles when the app user is already assigned to a staff
        var staffForAppUserId = await _staffRepository.GetStaffByAppUserId(request.AppUserId);
        
        if (staffForAppUserId != null)
        {
            throw new BadRequestException($"{nameof(Domain.Entities.AppUser)} with key {request.AppUserId} is already mapped to a staff");
        }
        // END

        var staff = _mapper.Map<Domain.Entities.Staff>(request);
        staff.Job = job;
        staff.AppUser = appUser;
        var staffId = await _idGenerator.GenerateStaffIDNumber();
        staff.StaffID = staffId;
        var response = await _staffRepository.CreateAsync(staff);
        var data = _mapper.Map<StaffDto>(response);
        return data;
    }
}
