using AutoMapper;
using HospitalManagement.Application.Contracts.Caching;
using HospitalManagement.Application.Contracts.Persistence;
using HospitalManagement.Application.Exceptions;
using MediatR;

namespace HospitalManagement.Application.Features.Department;

public class CreateNewDepartmentCommandHandler : IRequestHandler<CreateNewDepartmentCommand, DepartmentDto>
{
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;
    private readonly ICacheService _cacheService;

    public CreateNewDepartmentCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, ICacheService cacheService)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
        _cacheService = cacheService;
    }

    public async Task<DepartmentDto> Handle(CreateNewDepartmentCommand request, CancellationToken cancellationToken)
    {
        var validator = new CreateNewDepartmentCommandValidator(_unitOfWork);
        var validationResult = await validator.ValidateAsync(request);
        if (validationResult.Errors.Any())
        {
            throw new BadRequestException("", validationResult);
        }
        var departmentEntity = _mapper.Map<Domain.Entities.Department>(request);
        var data = await _unitOfWork.DepartmentRepository.CreateAsync(departmentEntity);
        await _unitOfWork.CompleteAsync();
        await _cacheService.RemoveRecordAsync("Departments");
        var response = _mapper.Map<DepartmentDto>(data);
        return response;
    }
}
