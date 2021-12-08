namespace MultipleDbEf.ModelTest;

public class PersonModelTest
{
    [Fact]
    public void Can_PersonModel_WorkProperly()
    {
        Person p = new() { Id = 1, Name = "Test p 1" };
        Assert.Equal(1, p.Id);
        Assert.Equal("Test p 1", p.Name);
    }
}