using System;

namespace ClassesApp;

internal class Car
{
    // member variable
    // private field hides variable from other classes
    private string _model = "";
    private string _brand = "";
    private bool _isLuxury;

    public string Model { get => _model; set => _model = value; }
    public string Brand { get => _brand; set
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
    } }

    // Constructor
    public Car(string model, string brand, bool isLuxury)
    {
        Model = model;
        Brand = brand;
        _isLuxury = isLuxury;
        Console.WriteLine($"A {brand} car of model {model} has been created");

    }
}
