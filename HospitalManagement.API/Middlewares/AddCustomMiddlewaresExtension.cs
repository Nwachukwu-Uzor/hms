using HR.LeaveManagement.Api.Middlewares;

namespace HospitalManagement.API.Middlewares;

public static class AddCustomMiddlewaresExtension
{
    public static IApplicationBuilder AddCustomMiddlewares(this IApplicationBuilder builder)
    {
       builder.UseMiddleware<TokenExtractorMiddleware>();
        builder.UseMiddleware<ExceptionHandlerMiddleware>();
        return builder;
    }
}
