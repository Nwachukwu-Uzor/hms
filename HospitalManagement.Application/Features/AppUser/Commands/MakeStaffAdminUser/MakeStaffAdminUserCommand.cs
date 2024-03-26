using HospitalManagement.Application.Features.Staff;
using MediatR;

namespace HospitalManagement.Application.Features.AppUser;

public record MakeStaffAdminUserCommand(string StaffID) : IRequest<StaffDto>;
