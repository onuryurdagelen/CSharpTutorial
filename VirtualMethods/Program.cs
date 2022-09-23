SqlServer sqlServer = new SqlServer();
sqlServer.Add();
MySql mySql = new MySql();
mySql.Add();




class Person
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string IdentityNumber { get; set; }
    public int Age { get; set; }

}
//Virtual base code'u ezer.
class Database
{
    public virtual void Add() {
        Console.WriteLine("Added by default");
    }
    public virtual void Delete() {
        Console.WriteLine("Deleted by default");

    }
}
class SqlServer:Database
{
    public override void Add()
    {
        Console.WriteLine("Added by SqlServer");
    }
}
class MySql : Database
{
    public override void Add()
    {
        Console.WriteLine("Added by MySql");

    }
}

class Customer:Person
{
    public string City { get; set; }
}
class Student:Person
{
    public string Department { get; set; }
}
