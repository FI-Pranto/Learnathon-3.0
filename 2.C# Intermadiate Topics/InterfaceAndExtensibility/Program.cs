namespace InterfaceAndExtensibility
{

    class FileLogger : ILogger
    {

        private readonly string _path;

        public FileLogger(string path)
        {
            _path = path;
        }
        public void LogError(string message)
        {
            Log(message, "Error");
        }

        public void LogInfo(string message)
        {
            Log(message, "Info");
        }

        private void Log(string message, string format)
        {
            Console.WriteLine(format+": "+message);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            //we are mainly extending the features of DBMigrator class without changing a single line of code of it
            //this is called extensibility

           // var dm = new DBMigrator(new ConsoleLogger());
            //dm.Migrate();
            var dm=new DBMigrator(new FileLogger(""));
            dm.Migrate();

           

        }
    }
}
