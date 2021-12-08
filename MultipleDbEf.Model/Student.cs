namespace MultipleDbEf.Model;

public class Student
{
    public int Id { get; set; }

    public string Name { get; set; }

    public Student()
    {
        Id = 0;
        Name = string.Empty;
    }
}