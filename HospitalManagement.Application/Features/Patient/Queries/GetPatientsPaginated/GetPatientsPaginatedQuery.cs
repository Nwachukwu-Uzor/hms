using HospitalManagement.Application.Features.Patient.DTOs;
using HospitalManagement.Application.Models.Persistence;
using MediatR;

namespace HospitalManagement.Application.Features.Patient;

public record GetPatientsPaginatedQuery(int Page, int PageSize) : IRequest<PaginatedData<PatientDto>>;
