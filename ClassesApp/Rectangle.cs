
namespace ClassesApp
{
    public class Rectangle
    {
        // Same value for all instances of the class
        public const int NumberOfCorners = 4;
        public readonly string Color;

        // Constructor(initialize color)
        public Rectangle(string color)
        {
            Color = color;
        }

        // Method to display details of the rectangle
        public void DisplayDetails()
        {
            Console.WriteLine($"Color: {Color} Width: {Width} Height: {Height} Number of corners: {NumberOfCorners}");
        }

        public double Width { get; set; }
        public double Height { get; set; }
    }
}