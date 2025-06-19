namespace ListApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare a list and initialize
            List<string> colors = new List<string>();
            // Add items
            colors.Add("red");
            colors.Add("blue");
            colors.Add("yellow");
            colors.Add("red");
            colors.Add("red");
            colors.Add("red");


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
