using AutoMapper;
using HospitalManagement.Application.Contracts.AuthService;
using HospitalManagement.Application.Contracts.Persistence;
using HospitalManagement.Application.Exceptions;
using HospitalManagement.Application.Models.AuthService;
using MediatR;
using Microsoft.Extensions.Options;

namespace HospitalManagement.Application.Features.AppUser;

public class LoginPatientUserCommandHandler : IRequestHandler<LoginPatientUserCommand, TokenData>
{
    private readonly IPasswordService _passwordService;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    private readonly IJwtTokenService _jwtTokenService;
    private readonly RolesId _rolesId;

    public LoginPatientUserCommandHandler(
        IPasswordService passwordService,
        IMapper mapper,
        IJwtTokenService jwtTokenService,
        IOptions<RolesId> rolesOptions,
        IUnitOfWork unitOfWork)
    {
        _passwordService = passwordService;
        _mapper = mapper;
        _jwtTokenService = jwtTokenService;
        _rolesId = rolesOptions.Value;
        _unitOfWork = unitOfWork;
    }
    public async Task<TokenData> Handle(LoginPatientUserCommand request, CancellationToken cancellationToken)
    {
        var user = await _unitOfWork.AppUserRepository.GetByEmail(request.Email);
        if (user == null)
        {
            throw new BadRequestException("Invalid user credentials");
        }

        // Check if the user is an admin user
        var isUserAPatient = user.Roles.Any(role => role.Id == _rolesId.PatientRoleId);

        if (!isUserAPatient)
        {
            throw new BadRequestException("Invalid user credentials");
        }

        var isPasswordValid = _passwordService.ComparePassword(request.Password, user.Password, user.Salt);
        if (!isPasswordValid)
        {
            throw new BadRequestException("Invalid user credentials");
        }
        var userResponse = _mapper.Map<AppUserDto>(user);
        return _jwtTokenService.GenerateToken(userResponse);
    }
}
