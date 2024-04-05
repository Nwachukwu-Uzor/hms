using HospitalManagement.Application.Models.Persistence;
using MediatR;

namespace HospitalManagement.Application.Features.Staff;

public record GetStaffPaginatedQuery(int Page, int PageSize) : IRequest<PaginatedData<StaffDto>>;
