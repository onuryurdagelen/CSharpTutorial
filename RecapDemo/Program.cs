Console.WriteLine("Hello, World!");
CustomerManager cManager = new CustomerManager();
cManager.logger = new DatabaseLogger();
cManager.Add();




class CustomerManager
{
    public ILogger logger { get; set; }
    public void Add()
    {
        Console.WriteLine("Customer Added");
        logger.Log();
    }
    

}
class DatabaseLogger : ILogger
{
    public void Log()
    {
        Console.WriteLine("Logged to Database!");
    }
}
class FileLogger : ILogger
{
    public void Log()
    {
        Console.WriteLine("Logged to File");
    }
}
interface ILogger
{
    public void Log();
}