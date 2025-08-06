namespace DelegatesAndEvents
{
    public delegate void LogHandler(string message);

    public class Logger
    {
        public void LogToConsole(string message)
        {
            Console.WriteLine("Console Log: " + message);
        }

        public void LogTofile(string message)
        {
            Console.WriteLine("File log: " + message);
        }
    }
    internal class Program
    {
        // 1. Declaration
        public delegate void Notify(string message);
        static void Main(string[] args)
        {
            // Delegates define a method signature
            // Any method assigned to delegate must match this signature

            // 2. Instantiation
            Notify notifyDelegate = ShowMessage;
            // Older C# versions
            // Notify notifyDelegate = new Notify(notifyDelegate);

            // 3. Invocation
            notifyDelegate("Delegate message");

            // Instance of Logger class
            Logger logger = new Logger();
            LogHandler logHandler = logger.LogToConsole;
            logHandler("Logging to console. Testing mode..");
            // Overwrite variable
            logHandler = logger.LogTofile;
            logHandler("Running second method");
        }

        static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }

}

