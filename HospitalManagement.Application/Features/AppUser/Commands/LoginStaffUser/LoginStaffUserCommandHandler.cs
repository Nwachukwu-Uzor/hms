using AutoMapper;
using HospitalManagement.Application.Contracts.AuthService;
using HospitalManagement.Application.Contracts.Logging;
using HospitalManagement.Application.Contracts.Persistence;
using HospitalManagement.Application.Exceptions;
using HospitalManagement.Application.Models.AuthService;
using MediatR;
using Microsoft.Extensions.Options;

namespace HospitalManagement.Application.Features.AppUser;


public class LoginStaffUserCommandHandler : IRequestHandler<LoginStaffUserCommand, TokenData>
{
    private readonly IPasswordService _passwordService;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    private readonly IJwtTokenService _jwtTokenService;
    private readonly RolesId _rolesId;
    private readonly IAppLogger<LoginStaffUserCommand> _logger;
    public LoginStaffUserCommandHandler(
        IPasswordService passwordService,
        IMapper mapper,
        IJwtTokenService jwtTokenService,
        IOptions<RolesId> rolesOptions,
        IUnitOfWork unitOfWork,
        IAppLogger<LoginStaffUserCommand> logger)
    {
        _passwordService = passwordService;
        _mapper = mapper;
        _jwtTokenService = jwtTokenService;
        _rolesId = rolesOptions.Value;
        _unitOfWork = unitOfWork;
        _logger = logger;
    }

    public async Task<TokenData> Handle(LoginStaffUserCommand request, CancellationToken cancellationToken)
    {
        var user = await _unitOfWork.AppUserRepository.GetByEmail(request.Email);
        if (user == null)
        {
            _logger.LogWarning($"Failed Login attempt for user {request.Email}");
            throw new BadRequestException("Invalid user credentials");
        }

        // Check if the user is a staff user
        var isUserAStaff = user.Roles.Any(role => role.Id == _rolesId.StaffRoleId);

        if (!isUserAStaff)
        {
            _logger.LogWarning($"Failed Login attempt for user with email {request.Email}", new { Message = "User is not a staff" });
            throw new BadRequestException("Invalid user credentials");
        }

        var isPasswordValid = _passwordService.ComparePassword(request.Password, user.Password, user.Salt);
        if (!isPasswordValid)
        {
            _logger.LogWarning($"Failed Login attempt for user with email {request.Email}", new { Message = "Invalid password" });
            throw new BadRequestException("Invalid user credentials");
        }
        var userResponse = _mapper.Map<AppUserDto>(user);
        return _jwtTokenService.GenerateToken(userResponse);
    }
}
