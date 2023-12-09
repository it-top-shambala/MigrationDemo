namespace MigrationDemo.BL.Model;

public enum PhoneType
{
    Unknown, Home, Mobile
}

public class Phone
{
    public int Id { get; set; }
    public PhoneType Type { get; set; }
    public string Number { get; set; }
}