namespace MultipleDbEf.Model;

public class Student
{
    public int Id { get; set; }

    public string Name { get; set; }

    public int Age { get; set; }

    public Student()
    {
        Id = 0;
        Name = string.Empty;
        Age = 0;
    }
}