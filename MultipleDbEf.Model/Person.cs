namespace MultipleDbEf.Model;

public class Person
{
    public int Id { get; set; }

    public string Name { get; set; }

    public Person()
    {
        Id = 0;
        Name = string.Empty;
    }
}