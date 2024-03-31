using HospitalManagement.Application;
using HospitalManagement.Infrastructure;
using HospitalManagement.Persistence;
using HR.LeaveManagement.Api.Middlewares;
using Microsoft.OpenApi.Models;
using Serilog;
// using dotenv.net;

var builder = WebApplication.CreateBuilder(args);
////DotEnv.Load();

// Add services to the container.
builder.Host.UseSerilog((context, loggerConfig) =>
    loggerConfig
    .WriteTo
    .Console()
    .ReadFrom.Configuration(context.Configuration)
);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo { Title = "Hospital Management System", Version = "v1" });
    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = "JWT Authorization header using the Bearer scheme. Example: \"Bearer {token}\"",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer",
    });
    options.AddSecurityRequirement(new OpenApiSecurityRequirement
        {
            {
                new OpenApiSecurityScheme
                {
                        Reference = new OpenApiReference
                        {
                            Type = ReferenceType.SecurityScheme,
                            Id = "Bearer"
                        },
                        Scheme = "0auth2",
                        Name = "Bearer",
                        In = ParameterLocation.Header

                },
                new string[] { }
            }
        });
});
builder.Services.AddApplicationServices(builder.Configuration);
builder.Services.AddInfrastructureServices(builder.Configuration, builder.Environment.IsDevelopment());
builder.Services.AddPersistenceServices(builder.Configuration, builder.Environment.IsDevelopment());
builder.Services.AddCors(options =>
{
    options.AddPolicy("all", option => option.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
});


var app = builder.Build();
app.UseCors("all");

// Configure the HTTP request pipeline.

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();
app.UseMiddleware<ExceptionHandlerMiddleware>();
app.UseSerilogRequestLogging();

app.MapControllers();

app.Run();
