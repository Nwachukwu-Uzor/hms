using AutoMapper;
using HospitalManagement.Application.Contracts.Caching;
using HospitalManagement.Application.Contracts.Persistence;
using HospitalManagement.Application.Exceptions;
using HospitalManagement.Application.Features.Patient.DTOs;
using HospitalManagement.Application.Models.Persistence;
using MediatR;

namespace HospitalManagement.Application.Features.Patient;

public class GetPatientsPaginatedQueryHandler : IRequestHandler<GetPatientsPaginatedQuery, PaginatedData<PatientDto>>
{
    private readonly ICacheService _cacheService;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetPatientsPaginatedQueryHandler(ICacheService cacheService, IUnitOfWork unitOfWork, IMapper mapper)
    {
        _cacheService = cacheService;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<PaginatedData<PatientDto>> Handle(GetPatientsPaginatedQuery request, CancellationToken cancellationToken)
    {
        var validator = new GetPatientsPaginatedQueryValidator();

        var validationResult = validator.Validate(request);
        if (validationResult.Errors.Any())
        {
            throw new BadRequestException(nameof(Domain.Entities.Patient), validationResult);
        }
        var cacheKey = $"GET_ALL_PATIENTS_PAGINATED_{request.Page}_{request.PageSize}";
        var recordFromCache = await _cacheService.GetRecordAsync<PaginatedData<PatientDto>>(cacheKey);
        if (recordFromCache != null)
        {
            return recordFromCache;
        }
        var staffData = await _unitOfWork.PatientRepository.GetAllPaginated(request.Page, request.PageSize);

        var response = _mapper.Map<PaginatedData<PatientDto>>(staffData);
        await _cacheService.SetRecordAsync(cacheKey, response, TimeSpan.FromMinutes(5));
        return response;
    }
}
