using Microsoft.EntityFrameworkCore;
using MultipleDbEf.Model;

namespace MultipleDbEf.Data;

public class PersonContext : DbContext
{
    public PersonContext(DbContextOptions<PersonContext> options)
        : base(options)
    {
        Persons = Set<Person>();
    }

    public DbSet<Person> Persons { get; set; }
}