﻿namespace MultipleDbEf.ModelTest;

public class StudentModelTest
{
    [Fact]
    public void Can_StudentModel_WorkProperly()
    {
        Student s = new() { Id = 1, Name = "Test s 1", Age = 15 };
        Assert.Equal(1, s.Id);
        Assert.Equal("Test s 1", s.Name);
        Assert.Equal(15, s.Age);
    }
}