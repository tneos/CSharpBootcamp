namespace InterfacesApp
{
    public interface IPaymentProcessor
    {
        void ProcessPayment(decimal amount);
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
   
    internal class Program
    {
        static void Main(string[] args)
        {
            IPaymentProcessor creditCardProcessor = new CreditCardPaymentProcessor();
            IPaymentProcessor paypalProcessor = new PaypalProcessor();

            PaymentService paymentService = new PaymentService(creditCardProcessor);
            paymentService.ProcessOrderPayment(100.00m);
            paymentService = new PaymentService(paypalProcessor);
            paymentService.ProcessOrderPayment(200.00m);

            Console.ReadKey();
        }
    }
    
}

