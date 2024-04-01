using FluentValidation;
using System;

namespace HospitalManagement.Application.Extensions.Validation;
public static class FluentValidationExtensions
{
    public static IRuleBuilderOptions<T, string> IsGuid<T>(this IRuleBuilder<T, string> ruleBuilder)
    {
        return ruleBuilder.Must((rootObject, stringValue, context) =>
        {
            if (!Guid.TryParse(stringValue, out _))
            {
                return false;
            }
            return true;
        }).WithMessage("Invalid GUID format");
    }
}
