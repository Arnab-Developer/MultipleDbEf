namespace MultipleDbEf.Api.EndPoints;

internal class StudentEndPoint : IEndPoint
{
    private readonly StudentContext _context;

    public StudentEndPoint(StudentContext context) => _context = context;

    void IEndPoint.Register(IEndpointRouteBuilder app)
    {
        app.MapGet("student", GetStudents);
        app.MapPost("student", CreateStudent);
    }

    internal IResult GetStudents() => Results.Ok(_context.Students.OrderBy(s => s.Id));

    internal IResult CreateStudent(Student student)
    {
        _context.Students.Add(new Student() { Name = student.Name });
        _context.SaveChanges();
        return Results.Ok();
    }
}