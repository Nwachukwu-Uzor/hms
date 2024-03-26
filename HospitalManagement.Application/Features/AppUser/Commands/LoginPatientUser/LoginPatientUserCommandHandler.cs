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
    private readonly IAppUserRepository _appUserRepository;
    private readonly IMapper _mapper;
    private readonly IJwtTokenService _jwtTokenService;
    private readonly RolesId _rolesId;

    public LoginPatientUserCommandHandler(
        IPasswordService passwordService,
        IAppUserRepository appUserRepository,
        IMapper mapper,
        IJwtTokenService jwtTokenService,
        IOptions<RolesId> rolesOptions
    )
    {
        _passwordService = passwordService;
        _appUserRepository = appUserRepository;
        _mapper = mapper;
        _jwtTokenService = jwtTokenService;
        _rolesId = rolesOptions.Value;
    }
    public async Task<TokenData> Handle(LoginPatientUserCommand request, CancellationToken cancellationToken)
    {
        var user = await _appUserRepository.GetByEmail(request.Email);
        if (user == null)
        {
            throw new BadRequestException("Invalid user credentials");
        }

        // Check if the user is an admin user
        var isUserAnAdmin = user.Roles.Any(role => role.Id == _rolesId.PatientRoleId);

        if (!isUserAnAdmin)
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
