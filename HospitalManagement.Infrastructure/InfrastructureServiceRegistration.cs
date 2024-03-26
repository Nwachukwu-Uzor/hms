using HospitalManagement.Application.Contracts.AuthService;
using HospitalManagement.Application.Contracts.IDGenerator;
using HospitalManagement.Application.Contracts.Logging;
using HospitalManagement.Application.Models.AuthService;
using HospitalManagement.Application.Models.IDGenerator;
using HospitalManagement.Infrastructure.AuthService;
using HospitalManagement.Infrastructure.Logging;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HospitalManagement.Infrastructure;

public static class InfrastructureServiceRegistration
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<PasswordSettings>(configuration.GetSection("PasswordSettings"));
        services.Configure<JwtSettings>(configuration.GetSection("Jwt"));
        services.Configure<IDSettings>(configuration.GetSection("IDSettings"));
        services.AddScoped<IPasswordService, PasswordService>();
        services.AddScoped<IRoleManager, RoleManager>();
        services.AddScoped<IJwtTokenService, JwtTokenService>();
        services.AddScoped<IIDGenerator, IDGenerator.IDGenerator>();
        services.AddScoped(typeof(IAppLogger<>), typeof(LoggerAdapter<>));
        return services;
    }
}