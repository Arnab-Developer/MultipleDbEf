using MultipleDbEf.Data;

namespace MultipleDbEf.Api.EndPoints;

internal class PersonEndPoint : IEndPoint
{
    private readonly PersonContext _context;

    public PersonEndPoint(PersonContext context) => _context = context;

    void IEndPoint.Register(IEndpointRouteBuilder app) => app.MapGet("person", GetPersons);

    internal IResult GetPersons() => Results.Ok(_context.Persons.OrderBy(p => p.Id));
}