using MigrationDemo.BL;

var service = new AppService();
var persons = service.GetAllPersons();

foreach (var p in persons)
{
    Console.WriteLine($"{p.FullName}");
    foreach (var phone in p.Phones)
    {
        Console.WriteLine($"\t[{phone.Id}]: {phone.Number} <{phone.Type}>");
    }
}
