using System;
using System.ComponentModel.DataAnnotations;

namespace ClassesApp;

internal class Customer
{
    // properties (default getter and setterss)
    public string Name { get; set; }
    public string Address { get; set; }
    public string ContactNumber { get; set; }

    // Default constructor(default values)
    public Customer()
    {
        Name = "No customer name set";
        Address = "No address registered";
        ContactNumber = "No contact number added";
    }


    // Custom Constructors
    public Customer(string name, string address, string contactNumber)
    {
        Name = name;
        Address = address;
        ContactNumber = contactNumber;
    }

    public Customer(string name)
    {
        Name = name;
    }

   // Method
    public void SetDetails(string name, string address, string contactNumber)
    {
        Name = name;
        Address = address;
        ContactNumber = contactNumber;
    }


   
    
}
