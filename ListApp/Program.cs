namespace ListApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare a list and initialize
            List<string> colors =
            [
                // Add items
                "red",
                "blue",
                "yellow",
                "red",
                "red",
                "red",
            ];

            // List of numbers
            List<int> numbers = new List<int> { 1, 3, 6, 23, 8, 5, 12 };

            // Sort numbers
            numbers.Sort();

            foreach (int number in numbers)
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
        }
    }
}
