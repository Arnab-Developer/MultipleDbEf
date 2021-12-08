namespace MultipleDbEf.Api.StartHelper;

internal static class MapEndpointExtensions
{
    public static void MapEndPoints(this IEndpointRouteBuilder app)
    {
        IServiceScope scope = app.ServiceProvider.CreateScope();
        IEnumerable<IEndPoint> endPoints = scope.ServiceProvider.GetServices<IEndPoint>();
        foreach (IEndPoint endPoint in endPoints)
        {
            endPoint.Register(app);
        }
    }
}