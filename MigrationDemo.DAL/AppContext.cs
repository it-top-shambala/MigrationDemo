using Microsoft.EntityFrameworkCore;
using MigrationDemo.DAL.Model;

namespace MigrationDemo.DAL;

public class AppContext : DbContext
{
    public DbSet<Person> Persons { get; set; }
    public DbSet<LastName> LastNames { get; set; }
    public DbSet<FirstName> FirstNames { get; set; }
    public DbSet<Phone> Phones { get; set; }

    public AppContext(DbContextOptions<AppContext> options) : base(options)
    { }
}