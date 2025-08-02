namespace StructsApp
{
    public struct Point
    {
        // Structs are immutable(readonly fields, no setter property)
         public double X { get; }
         public double Y { get; }

        // public int X;
        // public int Y;

        // Struct costructor
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        // Get distance between 2 points method
        public double DistanceTo(Point other)
        {
            double dx = other.X - X;
            double dy = other.Y - Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        // Method
        public void Display()
        {
            Console.WriteLine($"Point: ({X}, {Y})");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(12, 22);
            p1.Display();

            Point p2 = new Point(44, 45);
            // Another way of struct declaration(fields must be initialized when they are used)
            // Point p2;
            // p2.X = 33;
            // p2.Y = 45;
            p2.Display();

            // Structs are value types
            // Point p3 = p1;
            // p3.X = 50;
            // p1.Display();
            // p3.Display();

            // Get distance between two points
            double distance = p1.DistanceTo(p2);
            Console.WriteLine($"Distance between points: {distance:F2}");
        }
    }
}
