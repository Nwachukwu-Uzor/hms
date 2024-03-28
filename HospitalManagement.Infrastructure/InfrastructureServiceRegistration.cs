using HospitalManagement.Application.Contracts.AuthService;
using HospitalManagement.Application.Contracts.Caching;
using HospitalManagement.Application.Contracts.EmailService;
using HospitalManagement.Application.Contracts.IDGenerator;
using HospitalManagement.Application.Contracts.Logging;
using HospitalManagement.Application.Models.AuthService;
using HospitalManagement.Application.Models.EmailService;
using HospitalManagement.Application.Models.IDGenerator;
using HospitalManagement.Infrastructure.AuthService;
using HospitalManagement.Infrastructure.Caching;
using HospitalManagement.Infrastructure.EmailService;
using HospitalManagement.Infrastructure.Logging;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HospitalManagement.Infrastructure;

public static class InfrastructureServiceRegistration
{
    public static IServiceCollection AddInfrastructureServices(
        this IServiceCollection services,
        IConfiguration configuration,
        bool isDevelopment
    )
    {
        services.Configure<PasswordSettings>(configuration.GetSection("PasswordSettings"));
        services.Configure<JwtSettings>(configuration.GetSection("Jwt"));
        services.Configure<IDSettings>(configuration.GetSection("IDSettings"));
        services.AddScoped<IPasswordService, PasswordService>();
        services.AddScoped<IRoleManager, RoleManager>();
        services.AddScoped<IJwtTokenService, JwtTokenService>();
        services.AddScoped<IIDGenerator, IDGenerator.IDGenerator>();
        services.AddScoped(typeof(IAppLogger<>), typeof(LoggerAdapter<>));
        services.AddScoped<ICacheService, CacheService>();
        services.Configure<EmailSettings>(configuration.GetSection("EmailSettings"));
        services.AddScoped<IEmailSender, EmailSender>();

        services.AddStackExchangeRedisCache(options =>
        {
            options.Configuration = isDevelopment ? 
                                    configuration.GetSection("RedisConnections:Development").Value 
                                    : Environment.GetEnvironmentVariable(configuration.GetSection("RedisConnections:Production").Value);
            options.InstanceName = configuration.GetSection("RedisConnections:InstanceName").Value;

        });
        return services;
    }
}