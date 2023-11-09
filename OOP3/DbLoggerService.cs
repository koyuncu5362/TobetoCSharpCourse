namespace OOP3
{
    public class DbLoggerService : ILoggerService
    {
        public void Log(string message)
        {
            Console.WriteLine("Logged For Db");
        }
    }

    public class FileLoggerService : ILoggerService
    {
        public void Log(string message)
        {
            Console.WriteLine("Logged For File");
        }
    }
}
