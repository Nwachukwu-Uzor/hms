using MediatR;

namespace HospitalManagement.Application.Features.Staff;

public record GetStaffByStaffIdQuery(string StaffID) : IRequest<StaffDto>;
