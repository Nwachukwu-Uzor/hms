using HospitalManagement.Application;
using HospitalManagement.Infrastructure;
using HospitalManagement.Persistence;
using HR.LeaveManagement.Api.Middlewares;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddInfrastructureServices(builder.Configuration);
builder.Services.AddApplicationServices(builder.Configuration);
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

app.UseAuthorization();
app.UseMiddleware<ExceptionHandlerMiddleware>();

app.MapControllers();

app.Run();
