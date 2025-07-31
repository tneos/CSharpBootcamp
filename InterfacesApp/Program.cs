namespace InterfacesApp
{
    // Interfaces
    public interface IPaymentProcessor
    {
        void ProcessPayment(decimal amount);
    }

    
     public interface ILogger
    {
        void Log(string message);
    }


    // Class implements interface IPaymentProcessor
    public class CreditCardPaymentProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing credit card payment of {amount}");
            // Implement credit card payment logic
        }

    }

    public class PaypalProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing paypal payment of {amount}");
            // Implement paypal payment logic
        }
    }

    // Use interface
    public class PaymentService
    {
        private readonly IPaymentProcessor _processor;

        // constructor
        public PaymentService(IPaymentProcessor processor)
        {
            _processor = processor;
        }

        public void ProcessOrderPayment(decimal amount)
        {
            _processor.ProcessPayment(amount);
        }
    }
    
    
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            // The @ character in C# is used to denote a verbatim string literal
            string directoryPath = @"/Users/Isla/Documents";
            string filePath = Path.Combine(directoryPath, "log.txt");
            

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            File.AppendAllText(filePath, message + "\n");
        }
    }

    public class DatabaseLogger : ILogger
    {
        public void Log(string message)
        {
            // Implement logic to log a message to a database
            Console.WriteLine($"Logging to database. {message}");
        }
    }

    // Class that applies the logger
    /* Decoupling: Application class depends on ILogger interface rather than specific implementations
    like FileLogger or DatabaseLogger */
    public class Application
    {
        private readonly ILogger _logger;

        // Constructor
        public Application(ILogger logger)
        {
            _logger = logger;
        }

        // Method that uses the logger
        public void ApplyLogger()
        {
            _logger.Log("Work started");
            _logger.Log("WORK DONE!");
        }
    }
   
    internal class Program
    {
        static void Main(string[] args)
        {
            // IPaymentProcessor creditCardProcessor = new CreditCardPaymentProcessor();
            // IPaymentProcessor paypalProcessor = new PaypalProcessor();

            // PaymentService paymentService = new PaymentService(creditCardProcessor);
            // paymentService.ProcessOrderPayment(100.00m);
            // paymentService = new PaymentService(paypalProcessor);
            // paymentService.ProcessOrderPayment(200.00m);

            // Create a logger
            ILogger fileLogger = new FileLogger();
            // Create application
            Application app = new Application(fileLogger);
            app.ApplyLogger();

            ILogger dbLogger = new DatabaseLogger();
            // Overwrite app variable
            app = new Application(dbLogger);
            app.ApplyLogger();

            Console.ReadKey();
        }
    }
    
}

