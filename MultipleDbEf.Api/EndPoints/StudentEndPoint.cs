using MultipleDbEf.Data;

namespace MultipleDbEf.Api.EndPoints;

internal class StudentEndPoint : IEndPoint
{
    private readonly StudentContext _context;

    public StudentEndPoint(StudentContext context) => _context = context;

    void IEndPoint.Register(IEndpointRouteBuilder app) => app.MapGet("student", GetStudents);

    internal IResult GetStudents() => Results.Ok(_context.Students.OrderBy(s => s.Id));
}