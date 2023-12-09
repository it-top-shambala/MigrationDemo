namespace MigrationDemo.DAL.Model;

public class Person
{
    public int Id { get; set; }
    
    public int LastNameId { get; set; }
    public LastName LastName { get; set; }
    
    public int FirstNameId { get; set; }
    public FirstName FirstName { get; set; }

    public List<Phone> Phones { get; set; }
}