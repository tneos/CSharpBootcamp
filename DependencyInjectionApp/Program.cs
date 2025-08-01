using System.ComponentModel.DataAnnotations;
using DependencyInjectionApp;

namespace DependencyInjectionApp
{
    // Interface Dependency Injection
    public interface IToolUser
    {
        void SetHammer(Hammer hammer);
        void SetSaw(Saw saw);
    }
    public class Hammer
    {
        public void Use()
        {
            Console.WriteLine("Hammering Nails");
        }
    }

    public class Saw
    {
        public void Sawing()
        {
            Console.WriteLine("Sawing wood");
        }
    }

    // Builder class
    public class Builder: IToolUser
    { 
        // public  Hammer  Hammer { get; set; }
        // public Saw Saw { get; set; }


        private Hammer? _hammer;
        private Saw? _saw;

     
        // Constructor dependency injection
        // public Builder(Hammer hammer, Saw saw)
        // {
        //     _hammer = hammer;
        //     _saw = saw;

        // }

        public void SetHammer(Hammer hammer)
        {
            _hammer = hammer;
        }
        
         public void SetSaw(Saw saw)
        {
            _saw = saw;
        }



        // Action method
        public void BuildHouse()
        {
            _hammer?.Use();
            _saw?.Sawing();
            Console.WriteLine("House completed!");
        }
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        // New instances of tools and builder
        Hammer hammer = new Hammer();
        Saw saw = new Saw();
        //Builder builder = new Builder(hammer, saw);
        Builder builder = new Builder();
        // Setter dependency injection
        // builder.Hammer = hammer;
        // builder.Saw = saw;
        builder.SetHammer(hammer); ;
        builder.SetSaw(saw);

        builder.BuildHouse();
    }
}
