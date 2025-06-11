namespace ClassesApp;

class Program
{
    static void Main(string[] args)
    {
        // Customer tom = new Customer("Tom");
        // Customer susan = new Customer("Susan Smith", "12 Raith Dr", "08773342342");
        //Console.WriteLine("Name of customer is: " + tom.Name);
        // Default customer with no arguments given
        Customer defaultCustomer = new Customer();
        Console.WriteLine("Please enter the customer's name:");
        defaultCustomer.Name = Console.ReadLine();
        Console.WriteLine("Details about customer: " + defaultCustomer.Name);
        Customer customer1 = new Customer();
        // Use method
        customer1.SetDetails("Julia Walters", "12 Raith Str");
        Console.WriteLine("Here is new customer's details: " + customer1.Name + customer1.Address + customer1.ContactNumber);
        Console.ReadKey();
    }
}
