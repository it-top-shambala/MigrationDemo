namespace MigrationDemo.DAL.Model;

public enum PhoneType
{
    Unknown, Home, Mobile
}

public class Phone
{
    public int Id { get; set; }
    public PhoneType Type { get; set; }
    public string Number { get; set; }

    public int PersonId { get; set; }
    public Person Person { get; set; }
}