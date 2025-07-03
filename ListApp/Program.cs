namespace ListApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
            {
                new Product{Name = "razor", Price = 2.45},
                new Product{Name = "t-shirt", Price = 22.45},
                new Product{Name = "hat", Price = 12}
            };

            // Declare a list and initialize
            List<string> colors = new List<string>
            {
                // Add items
                "red",
                "blue",
                "yellow",
                "red",
                "red",
                "red"
            };

            // List of numbers
            List<int> numbers = new List<int> { 1, 3, 6, 23, 8, 5, 12 };

            // Sort numbers
            numbers.Sort();

            // Define the predicate to check the expression
            Predicate<int> isGreaterThanTwelve = num => num >= 12;

            // Find numbers that match expression(returns a list)
            List<int> higherOrEqualTwelve = numbers.FindAll(isGreaterThanTwelve);

            // Lamda expression passed as predicate to Any()
            bool equalToTwentyThree = higherOrEqualTwelve.Any(num => num == 23);

            if (equalToTwentyThree)
            {
                Console.WriteLine("There is a value equal to 23");
            }

            foreach (int number in higherOrEqualTwelve)
            {
                Console.WriteLine(number);
            }


            // Remove item
            bool isDeletingSuccessful = colors.Remove("red");

            // As long as successful deletion repeat action
            while (isDeletingSuccessful)
            {
                isDeletingSuccessful = colors.Remove("red");
            }

            Console.WriteLine("Current colours in the list");
            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }

            // Filter list with where(), create new list
            List<Product> cheapProducts = products.Where(p => p.Price < 20).ToList();
           

            // Display products based on Product class
            Console.WriteLine("Available cheap products:");

            foreach (Product product in cheapProducts)
            {
                Console.WriteLine($"Product name: {product.Name} for {product.Price:0.00}");
            }

            
        }
    }
}
