using MultipleDbEf.Data;
using MultipleDbEf.Model;

namespace MultipleDbEf.Api.EndPoints;

internal class PersonEndPoint : IEndPoint
{
    private readonly PersonContext _context;

    public PersonEndPoint(PersonContext context) => _context = context;

    void IEndPoint.Register(IEndpointRouteBuilder app)
    {
        app.MapGet("person", GetPersons);
        app.MapPost("person", CreatePerson);
    }

    internal IResult GetPersons() => Results.Ok(_context.Persons.OrderBy(p => p.Id));

    internal IResult CreatePerson(Person person)
    {
        _context.Persons.Add(person);
        _context.SaveChanges();
        return Results.Ok();
    }
}