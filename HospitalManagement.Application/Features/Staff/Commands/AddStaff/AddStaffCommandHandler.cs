using AutoMapper;
using HospitalManagement.Application.Contracts.IDGenerator;
using HospitalManagement.Application.Contracts.Persistence;
using HospitalManagement.Application.Exceptions;
using MediatR;

namespace HospitalManagement.Application.Features.Staff;

public class CompletePatientDetailsCommandHandler : IRequestHandler<AddStaffCommand, StaffDto>
{
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IAppUserRepository _appUserRepository;
    private readonly IIDGenerator _idGenerator;

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

        var job = await _unitOfWork.JobRepository.GetByIdAsync(request.JobId);

        if (job == null)
        {
            throw new NotFoundException(nameof(Domain.Entities.Job), request.JobId);
        }

        // START: Handles when the app user is already assigned to a staff
        var staffForAppUserId = await _unitOfWork.StaffRepository.GetStaffByAppUserId(request.AppUserId);
        
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
        var response = await _unitOfWork.StaffRepository.CreateAsync(staff);
        var data = _mapper.Map<StaffDto>(response);
        await _unitOfWork.CompleteAsync();
        return data;
    }
}
