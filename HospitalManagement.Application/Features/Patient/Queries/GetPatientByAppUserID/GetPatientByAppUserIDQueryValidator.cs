using FluentValidation;
using HospitalManagement.Application.Extensions.Validation;

namespace HospitalManagement.Application.Features.Patient;

public class GetPatientByAppUserIDQueryValidator : AbstractValidator<GetPatientByAppUserIDQuery>
{
    public GetPatientByAppUserIDQueryValidator()
    {
        RuleFor(member => member.AppUserID.ToString())
            .IsGuid().WithMessage("{PropertyName} not valid");
    }
}
