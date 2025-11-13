using Generics;

namespace MyApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // New instance Box class
            // Box<string> box = new Box<string>("Testing Generics");
            // box.UpdateContent("Content changed");
            // Console.WriteLine(box.GetContent());

            // Box<int, string> box = new Box<int, string>(100, "One hundred");
            // box.Display();
            Logger logger = new Logger();
            logger.Log("Logger new message");
            logger.Log(12);

            
            Box<Book> bookBox = new Box<Book>();
        }

    }
    
    class Book
    {
        
    }
}
