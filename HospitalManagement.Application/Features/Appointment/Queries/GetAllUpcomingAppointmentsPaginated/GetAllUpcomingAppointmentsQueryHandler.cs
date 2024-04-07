using AutoMapper;
using HospitalManagement.Application.Contracts.Caching;
using HospitalManagement.Application.Contracts.Persistence;
using HospitalManagement.Application.Exceptions;
using HospitalManagement.Application.Features.Appointment.DTOs;
using HospitalManagement.Application.Models.Persistence;
using MediatR;
using Microsoft.Extensions.Caching.Memory;

namespace HospitalManagement.Application.Features.Appointment;

public class GetAllUpcomingAppointmentsQueryHandler
: IRequestHandler<GetAllUpcomingAppointmentsPaginatedQuery, PaginatedData<AppointmentDto>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ICacheService _cacheService;
    private readonly IMapper _mapper;
    public GetAllUpcomingAppointmentsQueryHandler(IUnitOfWork unitOfWork, IMapper mapper, ICacheService cacheService)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _cacheService = cacheService;
    }

    public async Task<PaginatedData<AppointmentDto>> Handle(GetAllUpcomingAppointmentsPaginatedQuery request, CancellationToken cancellationToken)
    {
        var validator = new GetAllUpcomingAppointmentsQueryValidator();
        var validationResult = validator.Validate(request);
        if (validationResult.Errors.Any())
        {
            throw new BadRequestException(nameof(Domain.Entities.Appointment), validationResult);
        }
        var cacheKey = $"GET_ALL_UPCOMING_APPOINTMENTS_PAGINATED_{request.Page}_{request.PageSize}";
        var dataFromCache = await _cacheService.GetRecordAsync<PaginatedData<AppointmentDto>>(cacheKey);
        if (dataFromCache != null)
        {
            return dataFromCache;
        }
        var data = await _unitOfWork.AppointmentRepository.GetAllUpcomingAppointmentsPaginated(request.Page, request.PageSize);
        var response = _mapper.Map<PaginatedData<AppointmentDto>>(data);
        await _cacheService.SetRecordAsync(cacheKey, response, TimeSpan.FromMinutes(30));
        return response;
    }
}
