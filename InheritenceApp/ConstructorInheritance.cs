using System.Security.Cryptography.X509Certificates;

namespace InheritenceApp;

public class Person
{
    public string Name { get; private set; }
    public int Age { get; private set; }

    // Base class constructor
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
        Console.WriteLine("Person constructor called");
    }

    public void DisplayPersonInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }

   /// <summary>Icrease age property by a set number of years</summary>
        /// <param name="years">The parameter that indicates the amount of years to add to property.</param>
        /// <returns>Returns the new age.</returns>
    public int IncrementAge(int years)
    {
        Age = Age + years;
        return Age;
    }
}

// Derived class Employee 
public class Employee : Person
{
    public string JobTitle { get; private set; }
    public int EmployeeID { get; private set; }
    // Constructor
    public Employee(string name, int age, string jobTitle, int employeeId) : base(name, age)
    {
        JobTitle = jobTitle;
        EmployeeID = employeeId;
        Console.WriteLine("Employee constructor (derived class) called");
    }
    public void DisplayEmployeeInfo()
    {
        DisplayPersonInfo();  // Call method from base class
        Console.WriteLine($"Job Title: {JobTitle}, Employee ID: {EmployeeID}");

    }

}

// Second layer of derived class
    public class Manager : Employee
    {
        // Local property
        public int TeamSize { get; set; }

        public Manager(string name, int age, string jobTitle, int employeeId, int teamSize) : base(name, age, jobTitle, employeeId)
        {
            TeamSize = teamSize;
        }

        public void DisplayManagerInfo()
        {
            DisplayEmployeeInfo();
            Console.WriteLine($"Team size: {TeamSize}");
        }
    }