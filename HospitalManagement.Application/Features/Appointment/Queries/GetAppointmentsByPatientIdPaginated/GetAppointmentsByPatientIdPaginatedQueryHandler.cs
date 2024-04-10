using AutoMapper;
using FluentValidation;
using HospitalManagement.Application.Contracts.Caching;
using HospitalManagement.Application.Contracts.Persistence;
using HospitalManagement.Application.Exceptions;
using HospitalManagement.Application.Features.Appointment.DTOs;
using HospitalManagement.Application.Models.Persistence;
using MediatR;

namespace HospitalManagement.Application.Features.Appointment;

public class GetAppointmentsByPatientIdPaginatedQueryHandler
: IRequestHandler<GetAppointmentsByPatientIdPaginatedQuery, PaginatedData<AppointmentDto>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ICacheService _cacheService;
    private readonly IMapper _mapper;
    public GetAppointmentsByPatientIdPaginatedQueryHandler(IUnitOfWork unitOfWork, IMapper mapper, ICacheService cacheService)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _cacheService = cacheService;
    }
    public async Task<PaginatedData<AppointmentDto>> Handle(GetAppointmentsByPatientIdPaginatedQuery request, CancellationToken cancellationToken)
    {
        var validator = new GetAppointmentsByPatientIdPaginatedQueryValidator();
        var validationResult = validator.Validate(request);
        if (validationResult.Errors.Any())
        {
            throw new BadRequestException(nameof(Domain.Entities.Appointment), validationResult);
        }
        var cacheKey = $"GET_APPOINTMENTS_BY_PATIENTID_PAGINATED_{request.PatientId}_{request.Page}_{request.PageSize}";
        var dataFromCache = await _cacheService.GetRecordAsync<PaginatedData<AppointmentDto>>(cacheKey);
        if (dataFromCache != null)
        {
            return dataFromCache;
        }
        var data = await _unitOfWork.AppointmentRepository.GetAppointmentsByPatientIdPaginated(
            request.PatientId, 
            request.Page, 
            request.PageSize,
            request.Status,
            request.StartDate,
            request.EndDate
        );
        var response = _mapper.Map<PaginatedData<AppointmentDto>>(data);
        await _cacheService.SetRecordAsync(cacheKey, response, TimeSpan.FromMinutes(5));
        return response;
    }
}
