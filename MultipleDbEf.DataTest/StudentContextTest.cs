namespace MultipleDbEf.DataTest;

public class StudentContextTest
{
    [Fact]
    public void Can_StudentContext_InsertData()
    {
        Student student = new() { Name = "test student 1" };
        DbContextOptions<StudentContext> dbContextOptions =
            new DbContextOptionsBuilder<StudentContext>().UseInMemoryDatabase("TestStudentDb").Options;

        using (StudentContext studentContext = new(dbContextOptions))
        {
            studentContext.Students.Add(student);
            studentContext.SaveChanges();
        }

        using (StudentContext studentContext1 = new(dbContextOptions))
        {
            IList<Student> students = studentContext1.Students.ToList();
            Assert.Single(students);
            Assert.Equal("test student 1", students[0].Name);
        }
    }
}