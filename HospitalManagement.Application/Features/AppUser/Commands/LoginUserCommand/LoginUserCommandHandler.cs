using AutoMapper;
using HospitalManagement.Application.Contracts.AuthService;
using HospitalManagement.Application.Contracts.Persistence;
using HospitalManagement.Application.Exceptions;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Application.Features.AppUser.Commands.LoginUserCommand;


public class LoginUserCommandHandler : IRequestHandler<LoginUserCommand, string>
{
    private readonly IPasswordService _passwordService;
    private readonly IAppUserRepository _appUserRepository;
    private readonly IMapper _mapper;
    private readonly IJwtTokenService _jwtTokenService;
    public LoginUserCommandHandler(
        IPasswordService passwordService, 
        IAppUserRepository appUserRepository, 
        IMapper mapper, 
        IJwtTokenService jwtTokenService
    )
    {
        _passwordService = passwordService;
        _appUserRepository = appUserRepository;
        _mapper = mapper;
        _jwtTokenService = jwtTokenService;
    }

    public async Task<string> Handle(LoginUserCommand request, CancellationToken cancellationToken)
    {
        var user = await _appUserRepository.GetByEmail(request.Email);
        if(user == null)
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
