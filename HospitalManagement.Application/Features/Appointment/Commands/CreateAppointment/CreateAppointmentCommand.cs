using MediatR;

namespace HospitalManagement.Application.Features.Appointment;

public record CreateAppointmentCommand(Guid PatientId, Guid DoctorId, DateTime AppointmentTime, string Description="") : IRequest<Guid>;

