namespace MultipleDbEf.ApiTest;

public class StudentEndPointTest
{
    private static HttpContext CreateMockHttpContext() =>
        new DefaultHttpContext
        {
            RequestServices = new ServiceCollection().AddLogging().BuildServiceProvider(),
            Response =
            {
                Body = new MemoryStream()
            },
        };

    [Fact]
    public async Task Can_CreateStudent_InsertData()
    {
        DbContextOptions<StudentContext> dbContextOptions =
            new DbContextOptionsBuilder<StudentContext>().UseInMemoryDatabase("TestPersonDb").Options;

        using (StudentContext StudentContext = new(dbContextOptions))
        {
            Student Student = new() { Name = "test Student 1" };
            StudentEndPoint StudentEndPoint = new(StudentContext);
            StudentEndPoint.CreateStudent(Student);
        }

        using (StudentContext StudentContext1 = new(dbContextOptions))
        {
            StudentEndPoint StudentEndPoint = new(StudentContext1);
            IResult result = StudentEndPoint.GetStudents();
            HttpContext mockHttpContext = CreateMockHttpContext();
            await result.ExecuteAsync(mockHttpContext);

            mockHttpContext.Response.Body.Position = 0;
            JsonSerializerOptions jsonOptions = new(JsonSerializerDefaults.Web);
            IEnumerable<Student>? responseStudents = await JsonSerializer.DeserializeAsync<IEnumerable<Student>>(
                mockHttpContext.Response.Body, jsonOptions);

            Assert.NotNull(responseStudents);
            Assert.Equal(200, mockHttpContext.Response.StatusCode);
            Assert.Equal("test Student 1", responseStudents!.ElementAt(0).Name);
        }
    }
}
