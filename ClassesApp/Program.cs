namespace ClassesApp;

class Program
{
    static void Main(string[] args)
    {
        // Instances of Car class
        Car audi = new Car("A3", "Audi");
        Car bmw = new Car("i7", "BMW");

        Console.WriteLine("Please enter the Brand name");
        // Set Brand
        audi.Brand = Console.ReadLine() ?? "";
        // Get Brand
        Console.WriteLine("Brand is: " + audi.Brand);
    }
}
