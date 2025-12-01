using System;

namespace Generics;

// Type T, not related to a specific type (generic functionality across multiple classes)
// public class Box<T>
// {
//     private T content;

//     public Box(T initialValue)
//     {
//         content = initialValue;
//     }

//     // Update method
//     public void UpdateContent(T newContent)
//     {
//         content = newContent;
//         Console.WriteLine($"Updated content to {content}");
//     }

//     // Return content method
//     public T GetContent()
//     {
//         return content;
//     }
// }

// Class contains 2 generic types
// internal class Box<TFirst, TSecond>
// {
//     public TFirst First { get; set; }
//     public TSecond Second { get; set; }

      // Constructor initializes generic properties
//     public Box(TFirst first, TSecond second)
//     {
//         First = first;
//         Second = second;
//     }

//     public void Display()
//     {
//         Console.WriteLine($"First: {First}, Second: {Second}");
//     }
// }


// Constraint on generic type
internal class Box<T> where T : class
{

}
