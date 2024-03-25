using AutoMapper;
using HospitalManagement.Application.Contracts.IDGenerator;
using HospitalManagement.Application.Contracts.Persistence;
using HospitalManagement.Application.Exceptions;
using HospitalManagement.Application.Features.Staff.Queries.GetStaffByStaffId;
using MediatR;

namespace HospitalManagement.Application.Features.Staff.Commands.AddStaff;

public class AddStaffCommandHandler : IRequestHandler<AddStaffCommand, StaffDto>
{
    private readonly IMapper _mapper;
    private readonly IStaffRepository _staffRepository;
    private readonly IDepartmentRepository _departmentRepository;
    private readonly IAppUserRepository _appUserRepository;
    private readonly IIDGenerator _idGenerator;

    public AddStaffCommandHandler(
        IMapper mapper,
        IStaffRepository staffRepository,
        IDepartmentRepository departmentRepository,
        IAppUserRepository appUserRepository,
        IIDGenerator idGenerator
    )
    {
        _mapper = mapper;
        _staffRepository = staffRepository;
        _departmentRepository = departmentRepository;
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

        var department = await _departmentRepository.GetByIdAsync(request.DepartmentId);

        if (department == null)
        {
            throw new NotFoundException(nameof(Domain.Entities.Department), request.DepartmentId);
        }

        // START: Handles when the app user is already assigned to a staff
        var staffForAppUserId = await _staffRepository.GetStaffByAppUserId(request.AppUserId);
        
        if (staffForAppUserId != null)
        {
            throw new BadRequestException($"{nameof(Domain.Entities.AppUser)} with key {request.AppUserId} is already mapped to a staff");
        }
        // END

        var staff = _mapper.Map<Domain.Entities.Staff>(request);
        staff.Department = department;
        staff.AppUser = appUser;
        var staffId = await _idGenerator.GenerateStaffIDNumber();
        staff.StaffID = staffId;
        var response = await _staffRepository.CreateAsync(staff);
        var data = _mapper.Map<StaffDto>(response);
        return data;
    }
}
