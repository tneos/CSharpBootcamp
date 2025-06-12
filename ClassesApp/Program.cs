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
       // Console.WriteLine("Please enter the customer's name:");
        defaultCustomer.Name = Console.ReadLine();
        //Console.WriteLine("Details about customer: " + defaultCustomer.Name);
        Customer customer1 = new Customer();
        Customer customer2 = new Customer("Thomas Neos");
        Customer customer3 = new Customer();
        // Use method
        customer1.SetDetails("Julia Walters", "12 Raith Str");
        //Console.WriteLine("Here is new customer's details: " + customer1.Name + customer1.Address + customer1.ContactNumber);
        // customer1.GetId();
        // customer2.GetId();
        // customer3.GetId();
        // Set read-only property password
        customer3.Password = "3424253%hhhsdf";

        Rectangle rectangle1 = new Rectangle("Red");
        Rectangle rectangle2 = new Rectangle("blue");
        Console.ReadKey();
    }
}
