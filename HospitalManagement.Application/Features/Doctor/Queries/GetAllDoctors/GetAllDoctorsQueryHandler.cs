using AutoMapper;
using HospitalManagement.Application.Contracts.Caching;
using HospitalManagement.Application.Contracts.Persistence;
using HospitalManagement.Application.Features.Doctor.DTOs;
using MediatR;
namespace HospitalManagement.Application.Features.Doctor;

public class GetAllDoctorsQueryHandler : IRequestHandler<GetAllDoctorsQuery, List<DoctorDto>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ICacheService _cacheService;
    private readonly IMapper _mapper;

    public GetAllDoctorsQueryHandler(IUnitOfWork unitOfWork, ICacheService cacheService, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _cacheService = cacheService;
        _mapper = mapper;
    }

    public async Task<List<DoctorDto>> Handle(GetAllDoctorsQuery request, CancellationToken cancellationToken)
    {
        var cacheKey = "GET_ALL_DOCTORS_WITH_STAFF_DETAILS";

        var doctorsFromCache = await _cacheService.GetRecordAsync<List<DoctorDto>>(cacheKey);

        if (doctorsFromCache != null)
        {
            return doctorsFromCache;
        }
        var doctors = await _unitOfWork.DoctorRepository.GetAllWithStaffDetails();
        var response = _mapper.Map<List<DoctorDto>>(doctors);
        await _cacheService.SetRecordAsync(cacheKey, response, TimeSpan.FromMinutes(30));
        return response;
    }
}
