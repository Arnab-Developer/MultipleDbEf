namespace MultipleDbEf.ApiTest;

public class PersonEndPointTest
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
    public async Task Can_CreatePerson_InsertData()
    {
        DbContextOptions<PersonContext> dbContextOptions =
            new DbContextOptionsBuilder<PersonContext>().UseInMemoryDatabase("TestPersonDb").Options;

        using (PersonContext personContext = new(dbContextOptions))
        {
            Person person = new() { Name = "test person 1" };
            PersonEndPoint personEndPoint = new(personContext);
            personEndPoint.CreatePerson(person);
        }

        using (PersonContext personContext1 = new(dbContextOptions))
        {
            PersonEndPoint personEndPoint = new(personContext1);
            IResult result = personEndPoint.GetPersons();
            HttpContext mockHttpContext = CreateMockHttpContext();
            await result.ExecuteAsync(mockHttpContext);

            mockHttpContext.Response.Body.Position = 0;
            JsonSerializerOptions jsonOptions = new(JsonSerializerDefaults.Web);
            IEnumerable<Person>? responsePersons = await JsonSerializer.DeserializeAsync<IEnumerable<Person>>(
                mockHttpContext.Response.Body, jsonOptions);

            Assert.NotNull(responsePersons);
            Assert.Equal(200, mockHttpContext.Response.StatusCode);
            Assert.Equal("test person 1", responsePersons!.ElementAt(0).Name);
        }
    }
}