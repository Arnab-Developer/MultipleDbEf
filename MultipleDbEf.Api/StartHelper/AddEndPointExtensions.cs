using MultipleDbEf.Api.EndPoints;

namespace MultipleDbEf.Api.StartHelper;

internal static class AddEndPointExtensions
{
    internal static void AddEndPoints(this IServiceCollection services)
    {
        services.AddScoped<IEndPoint, StudentEndPoint>();
        services.AddScoped<IEndPoint, PersonEndPoint>();
    }
}