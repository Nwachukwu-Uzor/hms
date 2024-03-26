using AutoMapper;
using HospitalManagement.Application.Contracts.Persistence;
using HospitalManagement.Application.Exceptions;
using MediatR;

namespace HospitalManagement.Application.Features.Staff;

public class GetStaffByStaffIDQueryHandler : IRequestHandler<GetStaffByStaffIdQuery, StaffDto>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetStaffByStaffIDQueryHandler(IMapper mapper, IUnitOfWork unitOfWork)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }

    public async Task<StaffDto> Handle(GetStaffByStaffIdQuery request, CancellationToken cancellationToken)
    {
        var staff = await _unitOfWork.StaffRepository.GetStaffByStaffID(request.StaffID);
        if (staff == null)
        {
            throw new NotFoundException(nameof(Domain.Entities.Staff), request.StaffID);
        }
        var response = _mapper.Map<StaffDto>(staff);
        return response;
    }
}
