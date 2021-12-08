namespace MultipleDbEf.DataTest;

public class PersonContextTest
{
    [Fact]
    public void Can_PersonContext_InsertData()
    {
        DbContextOptions<PersonContext> dbContextOptions =
            new DbContextOptionsBuilder<PersonContext>().UseInMemoryDatabase("TestPersonDb").Options;

        using (PersonContext personContext = new(dbContextOptions))
        {
            Person person = new() { Name = "test person 1" };
            personContext.Persons.Add(person);
            personContext.SaveChanges();
        }

        using (PersonContext personContext1 = new(dbContextOptions))
        {
            IList<Person> persons = personContext1.Persons.ToList();
            Assert.Single(persons);
            Assert.Equal("test person 1", persons[0].Name);
        }
    }
}