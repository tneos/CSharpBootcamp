using Generics;
using System.Reflection;

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
            
            // Product class implements interface, constraint passed
            Repository<Product> repository = new Repository<Product>();
            var product = new Product();
            repository.Add(product);
            var book1 = new Book();
            var book2 = new Book();
            // Call static method of Comparer
            Comparer.AreEqual(book1, book2);
            
            // Get info about generic type 
            Type type = typeof(Repository<>);

            // Actions don't return values
            Action action = () => {Console.WriteLine("Action applied");};
            Action<float, float, float> sum = (x, y, z) =>
            {
                Console.WriteLine(x + y + z);
            };
            
            action();
            sum(1, 1, 4);

            // Funcs return a value(returned type defined)
            Func<string> getName = () =>
            {
                return "Thomas";
            };
            
            // Parameters and returned type defined
            Func<int, int, string> addition = (num1, num2) =>
            {
                return (num1 + num2).ToString();
            };

            Console.WriteLine(addition);

            // Predicate returns a bool (condition checking)
            Predicate<int> isEven = (x) =>
            {
                return x % 2 == 0;
            };

            List<int> intNumbersList = new List<int>(){1, 2, 5, 9, 12, 33, 45};
            var evenInts = intNumbersList.FindAll(isEven);

            Console.WriteLine(isEven(9));


        }

    }

    class Book
    {

    }
    
    class Product: IEntity
    {
        public int Id { get; set; }
    }

    // Generic interface (flexible contract across multiple classes)
    internal interface IRepository<T> 
    {
        void Add(T entity);
        void Remove(T entity);
    }

   // class implements constraint interface
    internal class ProductsList:IEntity
    {
        public int Id { get; set; }
        public required string Name { get; set; }
    }

    // Generic class implements generic interface
    internal class Repository<T>: IRepository<T>
    {
        
        public void Add(T entity)
        {
            
        }

        public void Remove(T entity)
        {
            
        }
    }
}


