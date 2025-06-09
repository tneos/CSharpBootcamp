using System;

namespace ClassesApp;

internal class Car
{
    // member variable
    // private field hides variable from other classes
    // Backing fields
    //private string _model = "";
    private string _brand = "";
    private bool _isLuxury;

    // lambda expression
    //public string Model { get => _model; set => _model = value; }
    public string Model{ get; set; }
    public string Brand
    {
        get
        {
            if (_isLuxury)
            {
                return _brand + " - Luxury Edition";
            }
            else { return _brand; }
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                Console.WriteLine("You haven't entered a valid value");
                _brand = "Not set";
            }
            else
            {
                _brand = value;
            }
        }
    }

    public bool IsLuxury { get => _isLuxury; set => _isLuxury = value; }
    

    // Constructor
    public Car(string model, string brand, bool isLuxury)
    {
        Model = model;
        Brand = brand;
        IsLuxury = isLuxury;
        Console.WriteLine($"A {brand} car of model {model} has been created");

    }
}
