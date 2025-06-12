

namespace ClassesApp;

internal class Customer
{
    // properties (default getter and setterss)
    private static int nextId = 0;
    // Identifier for every object 
    private readonly int _id;
    // Read Only property(without setter), exposes private property

    // Write only property
    private string _password;

    public string Password
    {
        set
        {
            _password = value;

        }
    }
    public int Id
    {
        get
        { return _id; }
    }
    public string Name { get; set; }
    public string Address { get; set; }
    public string ContactNumber { get; set; }

    // Default constructor(default values)
    public Customer()
    {
        // Assign and increment for every instance
        _id = nextId++;
        Name = "No customer name set";
        Address = "No address registered";
        ContactNumber = "No contact number added";
    }


    // Constructor (some parameters with default values)
    public Customer(string name, string address = "NA", string contactNumber = "NA")
    {
        // Assign and increment for every instance
        _id = nextId++;
        Name = name;
        Address = address;
        ContactNumber = contactNumber;
    }



    // Method (default parameter contactNumber)
    public void SetDetails(string name, string address, string contactNumber = "NA")
    {
        Name = name;
        Address = address;
        ContactNumber = contactNumber;
    }

    // Get id of every customer
    public void GetId()
    {
        Console.WriteLine($"ID of customer {Name} is: {_id}");
    }


   
    
}
