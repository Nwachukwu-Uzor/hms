using HospitalManagement.Application.Features.Patient.DTOs;
using MediatR;

namespace HospitalManagement.Application.Features.Patient;

public record GetPatientByAppUserIDQuery(Guid AppUserID) : IRequest<PatientDto>;