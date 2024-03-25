using HospitalManagement.Application.Features.Staff.Queries.GetStaffByStaffId;
using MediatR;

namespace HospitalManagement.Application.Features.Staff.Queries.GetStaffByStaffID;

public record GetStaffByStaffIdQuery(string StaffID) : IRequest<StaffDto>;
