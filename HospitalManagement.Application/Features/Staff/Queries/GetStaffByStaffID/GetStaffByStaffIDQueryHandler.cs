using AutoMapper;
using HospitalManagement.Application.Contracts.Persistence;
using HospitalManagement.Application.Exceptions;
using HospitalManagement.Application.Features.Staff.Queries.GetStaffByStaffId;
using MediatR;

namespace HospitalManagement.Application.Features.Staff.Queries.GetStaffByStaffID;

public class GetStaffByStaffIDQueryHandler : IRequestHandler<GetStaffByStaffIdQuery, StaffDto>
{
    private readonly IStaffRepository _staffRepository;
    private readonly IMapper _mapper;

    public GetStaffByStaffIDQueryHandler(IStaffRepository staffRepository, IMapper mapper)
    {
        _staffRepository = staffRepository;
        _mapper = mapper;
    }

    public async Task<StaffDto> Handle(GetStaffByStaffIdQuery request, CancellationToken cancellationToken)
    {
        var staff = await _staffRepository.GetStaffByStaffID(request.StaffID);
        if (staff == null)
        {
            throw new NotFoundException(nameof(Domain.Entities.Staff), request.StaffID);
        }
        var response = _mapper.Map<StaffDto>(staff);
        return response;
    }
}
