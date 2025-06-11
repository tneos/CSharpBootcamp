// C# program to illustrate the
// unary operator overloading
using System;
namespace Calculator {
    
class Calculator {
    
    public int number1 , number2;
    public Calculator(int num1 , int num2)
    {
        number1 = num1;
        number2 = num2;
    }
    
// Function to perform operation
// By changing sign of integers
public static Calculator operator -(Calculator c1)
{
    c1.number1 = -c1.number1;
    c1.number2 = -c1.number2;
    return c1;
}

// Function to print the numbers
public void Print()
{
    Console.WriteLine ("Number1 = " + number1);
    Console.WriteLine ("Number2 = " + number2);
}
}

class EntryPoint
{
    
    // Driver Code
    static void Main(String []args)
    { 
        
        // using overloaded - operator 
        // with the class object
        Calculator calc = new Calculator(15, -25);
        
        calc = -calc;
        
        // To display the result
        calc.Print();
    }
}
}
