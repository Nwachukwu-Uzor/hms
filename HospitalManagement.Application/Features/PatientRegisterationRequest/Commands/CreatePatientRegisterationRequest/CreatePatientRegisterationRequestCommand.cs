using MediatR;

namespace HospitalManagement.Application.Features.PatientRegisterationRequest;

public record CreatePatientRegisterationRequestCommand(string Email) : IRequest<Unit>;

