using HospitalManagement.Application.Contracts.AuthService;
using HospitalManagement.Application.Models.AuthService;
using HospitalManagement.Infrastructure.AuthService;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HospitalManagement.Infrastructure;

public static class InfrastructureServiceRegistration
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<PasswordSettings>(configuration.GetSection("PasswordSettings"));
        services.AddScoped<IPasswordService, PasswordService>();
        services.AddScoped<IRoleManager, RoleManager>();
        return services;
    }
}