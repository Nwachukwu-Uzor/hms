using HospitalManagement.Application.Features.Doctor.DTOs;
using MediatR;

namespace HospitalManagement.Application.Features.Doctor;

public record GetAllDoctorsQuery() : IRequest<List<DoctorDto>>;
