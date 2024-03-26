﻿using AutoMapper;
using HospitalManagement.Application.Contracts.AuthService;
using HospitalManagement.Application.Contracts.Persistence;
using HospitalManagement.Application.Exceptions;
using HospitalManagement.Application.Features.Staff;
using HospitalManagement.Application.Models.AuthService;
using HospitalManagement.Application.Models.IDGenerator;
using MediatR;
using Microsoft.Extensions.Options;

namespace HospitalManagement.Application.Features.AppUser;

public class MakeStaffAdminUserCommandHandler : IRequestHandler<MakeStaffAdminUserCommand, StaffDto>
{
    private readonly IStaffRepository _staffRepository;
    private readonly IMapper _mapper;
    private readonly IDSettings _idSettings;
    private readonly IRoleManager _roleManager;
    private readonly RolesId _rolesId;

    public MakeStaffAdminUserCommandHandler(
        IStaffRepository staffRepository, 
        IMapper mapper,
        IRoleManager roleManager,
        IOptions<IDSettings> idOptions,
        IOptions<RolesId> rolesOption
    )
    {
        _staffRepository = staffRepository;
        _mapper = mapper;
        _idSettings = idOptions.Value;
        _roleManager = roleManager;
        _rolesId = rolesOption.Value;
    }

    public async Task<StaffDto> Handle(MakeStaffAdminUserCommand request, CancellationToken cancellationToken)
    {
        var validator = new MakeStaffAdminUserCommandValidator(_idSettings);
        var validationResult = validator.Validate(request);
        if (validationResult.Errors.Any())
        {
            throw new BadRequestException($"{nameof(Domain.Entities.Staff)} returns validation errors", validationResult);
        }
        var staff = await _staffRepository.GetStaffByStaffID(request.StaffID);
        if (staff == null)
        {
            throw new NotFoundException(nameof(Domain.Entities.Staff), request.StaffID);
        }
        await _roleManager.AddUserToRole(staff.AppUser.Id, _rolesId.AdminRoleId);
        var response = _mapper.Map<StaffDto>(staff);
        return response;
    }
}
