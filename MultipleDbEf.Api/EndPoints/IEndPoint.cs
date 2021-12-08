namespace MultipleDbEf.Api.EndPoints;

internal interface IEndPoint
{
    public void Register(IEndpointRouteBuilder app);
}