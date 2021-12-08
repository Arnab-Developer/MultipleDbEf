namespace MultipleDbEf.ModelTest;

public class PersonModelTest
{
    [Fact]
    public void Can_PersonModel_WorkProperly()
    {
        Person p = new() { Id = 1, Name = "Test p 1", Age = 10 };
        Assert.Equal(1, p.Id);
        Assert.Equal("Test p 1", p.Name);
        Assert.Equal(10, p.Age);
    }
}