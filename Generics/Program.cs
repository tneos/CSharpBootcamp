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
            
            // Product class implements interface, constraint passed
            Repository<Product> repository = new Repository<Product>();
            var product = new Product();
            repository.Add(product);
            var book1 = new Book();
            var book2 = new Book();
            // Call static method of Comparer
            Comparer.AreEqual(book1, book2);


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
    internal interface IRepository<T> where T: IEntity
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

    internal class ProductRepository: IRepository<ProductsList>
    {
        
        public void Add(ProductsList entity)
        {
            
        }

        public void Remove(ProductsList entity)
        {
            
        }
    }
}


