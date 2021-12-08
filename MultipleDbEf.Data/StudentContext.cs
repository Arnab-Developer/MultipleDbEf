using Microsoft.EntityFrameworkCore;
using MultipleDbEf.Model;

namespace MultipleDbEf.Data;

public class StudentContext : DbContext
{
    public StudentContext(DbContextOptions<StudentContext> options)
        : base(options)
    {
        Students = Set<Student>();
    }

    public DbSet<Student> Students { get; set; }
}