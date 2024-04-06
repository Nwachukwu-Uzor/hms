using AutoMapper;
using HospitalManagement.Application.Contracts.Caching;
using HospitalManagement.Application.Contracts.Persistence;
using HospitalManagement.Application.Exceptions;
using HospitalManagement.Application.Models.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Application.Features.Staff;
public class GetStaffPaginatedQueryHandler : IRequestHandler<GetStaffPaginatedQuery, PaginatedData<StaffDto>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    private readonly ICacheService _cacheService;

    public GetStaffPaginatedQueryHandler(IUnitOfWork unitOfWork, IMapper mapper, ICacheService cacheService)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _cacheService = cacheService;
    }

    public async Task<PaginatedData<StaffDto>> Handle(GetStaffPaginatedQuery request, CancellationToken cancellationToken)
    {
        var validator = new GetStaffPaginatedQueryValidator();
        var validationResult = validator.Validate(request);
        if (validationResult.Errors.Any())
        {
            throw new BadRequestException(nameof(Domain.Entities.Patient), validationResult);
        }
        var cacheKey = $"GET_ALL_STAFF_PAGINATED_{request.Page}_{request.PageSize}";
        var recordFromCache = await _cacheService.GetRecordAsync<PaginatedData<StaffDto>>(cacheKey);
        if (recordFromCache != null)
        {
            return recordFromCache;
        }
        var staffData = await _unitOfWork.StaffRepository.GetAllPaginated(request.Page, request.PageSize);

        var response = _mapper.Map<PaginatedData<StaffDto>>(staffData);
        await _cacheService.SetRecordAsync(cacheKey, response, TimeSpan.FromMinutes(5));
        return response;
    }
}