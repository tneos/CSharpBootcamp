namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaring and initializing a dictionary
            Dictionary<int, string> employees = new Dictionary<int, string>();

            // Add items in dictionary collection
            employees.Add(101, "Bob Smith");
            employees.Add(102, "Steven Walters");
            employees.Add(103, "Anna Williamson");
            employees.Add(104, "John Taylor");

            // Access items in a dictionary
            string employeeName = employees[102];
            Console.WriteLine(employeeName);

            // Update data in a dictionary
            employees[102] = "Steve Walters";

            // Remove an item
            employees.Remove(103);

            // If key doesn't exist add an item
            if (!employees.ContainsKey(105))
            {
                employees.Add(105, "Tom Newton");
            }

            // Alternatively -- TryAdd() method, returns true if successful
            bool added = employees.TryAdd(102, "Nick Dramon");
            if (!added)
            {
                Console.WriteLine("Employee already exists");
            }

            // Iterate over items
            foreach (KeyValuePair<int, string> item in employees)
            {
                Console.WriteLine($"ID: {item.Key}, Name: {item.Value}");
            }
        }
    }
}


