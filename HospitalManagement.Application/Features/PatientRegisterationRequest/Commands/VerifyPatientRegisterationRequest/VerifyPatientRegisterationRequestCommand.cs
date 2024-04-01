using MediatR;

namespace HospitalManagement.Application.Features.PatientRegisterationRequest;

public class VerifyPatientRegisterationRequestCommand : IRequest<PatientRegisterationRequestDTO>
{
    public string AccessCode { get; set; }
    public Guid Id { get; set; }
}
