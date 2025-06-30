namespace Dictionary
{
    class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public int Salary { get; set; }

        public Employee(string name, int age, int salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialize a dictionary of objects
            Dictionary<int, Employee> employees = new Dictionary<int, Employee>();
            employees.Add(1, new Employee("Tom Smith", 32, 50000));
            employees.Add(2, new Employee("Tom Sonders", 36, 56000));
            employees.Add(3, new Employee("Larry Thomson", 30, 40000));
            employees.Add(4, new Employee("Lisa Naysmith", 42, 59000));
            employees.Add(5, new Employee("Nick Simms", 39, 60000));

            // Declaring and initializing a dictionary
            //Dictionary<int, string> employees = new Dictionary<int, string>();

            // Add items in dictionary collection
            // employees.Add(101, "Bob Smith");
            // employees.Add(102, "Steven Walters");
            // employees.Add(103, "Anna Williamson");
            // employees.Add(104, "John Taylor");

            // Access items in a dictionary
            // string employeeName = employees[102];
            // Console.WriteLine(employeeName);

            // Update data in a dictionary
            //employees[102] = "Steve Walters";

            // Remove an item
            //employees.Remove(103);

            // If key doesn't exist add an item
            // if (!employees.ContainsKey(105))
            // {
            //     employees.Add(105, "Tom Newton");
            // }

            // Alternatively -- TryAdd() method, returns true if successful
            // bool added = employees.TryAdd(102, "Nick Dramon");
            // if (!added)
            // {
            //     Console.WriteLine("Employee already exists");
            // }

            // Iterate over items
            // foreach (KeyValuePair<int, string> item in employees)
            // {
            //     Console.WriteLine($"ID: {item.Key}, Name: {item.Value}");
            // }

            // Iterate over dictionary of objects
            foreach (var item in employees)
            {
                Console.WriteLine($"ID: {item.Key} with the name {item.Value.Name}, earns {item.Value.Salary}, and is {item.Value.Age} years old");
            }
        }
    }
}


