
Database sqlServer = new SqlServer();
sqlServer.Delete();
Database oracle = new Oracle();
oracle.Delete();




//Abstract class'lar new'lenemezler.
abstract class Database
{

    //Ekleme işlemi heryerde aynı.Tamamlanmış metot yazılmıştır.
    public void Add()
    {
        Console.WriteLine("Added by default");
    }
    public abstract void Delete();

}

class SqlServer : Database
{
    public override void Delete()
    {
        Console.WriteLine("Deleted by SqlServer Code");
    }
}
class Oracle : Database
{
    public override void Delete()
    {
        Console.WriteLine("Deleted by Oracle Code");
    }
}