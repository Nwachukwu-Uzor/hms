using HospitalManagement.Application.Features.Patient.DTOs;
using MediatR;

namespace HospitalManagement.Application.Features.Patient.Queries.GetPatientByPatientID;

public record GetPatientByPatientIDQuery(string PatientID) : IRequest<PatientDto>;
