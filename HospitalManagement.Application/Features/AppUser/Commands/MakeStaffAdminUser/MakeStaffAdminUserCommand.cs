using HospitalManagement.Application.Features.Staff.Queries.GetStaffByStaffId;
using MediatR;

namespace HospitalManagement.Application.Features.AppUser.Commands.MakeStaffAdminUser;

public record MakeStaffAdminUserCommand(string StaffID) : IRequest<StaffDto>;
