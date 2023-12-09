using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MigrationDemo.BL.Model;
using AppContext = MigrationDemo.DAL.AppContext;

namespace MigrationDemo.BL;

public class AppService
{
    private readonly DbContextOptions<AppContext> _options;
    
    public AppService()
    {
        var builder = new ConfigurationBuilder();
        builder.SetBasePath(Directory.GetCurrentDirectory());
        builder.AddJsonFile("appsettings.json");
        var config = builder.Build();
        
        var connectionString = config.GetConnectionString("DefaultConnection");
        var optionsBuilder = new DbContextOptionsBuilder<AppContext>();
        _options = optionsBuilder.UseNpgsql(connectionString).Options;
    }

    public IEnumerable<Person> GetAllPersons()
    {
        using var db = new AppContext(_options);
        var persons = db.Persons
            .Include(person => person.LastName)
            .Include(person => person.FirstName)
            .Include(person => person.Phones)
            .Select(Mapper.MapPersonDALToPersonBL)
            .ToList();
        return persons;
    }

    public Person? FindPersonById(int id)
    {
        using var db = new AppContext(_options);
        return Mapper.MapPersonDALToPersonBL(db.Persons.FirstOrDefault(p => p.Id == id));
    }
}