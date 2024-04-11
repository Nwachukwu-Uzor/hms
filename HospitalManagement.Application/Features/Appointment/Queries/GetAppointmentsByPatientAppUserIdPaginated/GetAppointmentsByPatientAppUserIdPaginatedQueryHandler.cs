using AutoMapper;
using FluentValidation;
using HospitalManagement.Application.Contracts.Caching;
using HospitalManagement.Application.Contracts.Persistence;
using HospitalManagement.Application.Exceptions;
using HospitalManagement.Application.Features.Appointment.DTOs;
using HospitalManagement.Application.Models.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Application.Features.Appointment;

public class GetAppointmentsByPatientAppUserIdPaginatedQueryHandler
: IRequestHandler<GetAppointmentsByPatientAppUserIdPaginatedQuery, PaginatedData<AppointmentDto>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ICacheService _cacheService;
    private readonly IMapper _mapper;
    public GetAppointmentsByPatientAppUserIdPaginatedQueryHandler(IUnitOfWork unitOfWork, IMapper mapper, ICacheService cacheService)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _cacheService = cacheService;
    }
    public async Task<PaginatedData<AppointmentDto>> Handle(GetAppointmentsByPatientAppUserIdPaginatedQuery request, CancellationToken cancellationToken)
    {
        var validator = new GetAppointmentsByPatientAppUserIdPaginatedQueryValidator();
        var validationResult = validator.Validate(request);
        if (validationResult.Errors.Any())
        {
            throw new BadRequestException(nameof(Domain.Entities.Appointment), validationResult);
        }
        var cacheKey = $"GET_APPOINTMENTS_BY_PATIENTID_PAGINATED_" +
            $"{request.PatientId}_{request.Page}_{request.PageSize}_{request.StartDate.ToShortDateString}" +
            $"{request.EndDate.ToShortDateString}";

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
