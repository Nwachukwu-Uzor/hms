using HospitalManagement.Application.Contracts.Persistence;
using HospitalManagement.Persistence.Repositories;
using HR.LeaveManagement.Application.Contracts.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HospitalManagement.Persistence;

public static class PersistenceServiceRegisteration
{
    public static IServiceCollection AddPersistenceServices(
        this IServiceCollection services, 
        IConfiguration configuration, 
        bool isDevelopment
    )
    {
        if (isDevelopment)
        {
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("Development"));
            });
        }
        else
        {
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseNpgsql(Environment.GetEnvironmentVariable(configuration.GetConnectionString("Production")));
            });
        }
        services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        services.AddScoped<IJobRepository, JobRepository>();
        services.AddScoped<IRoleRepository, RoleRepository>();
        services.AddScoped<IStaffRepository, StaffRepository>();
        services.AddScoped<IAppUserRepository, AppUserRepository>();
        services.AddScoped<IPatientRepository, PatientRepository>();
        services.AddScoped<IDepartmentRepository, DepartmentRepository>();
        services.AddScoped<IPatientRegisterationRequestRepository, PatientRegisterationRequestRepository>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();
       
        return services;
    }
}
