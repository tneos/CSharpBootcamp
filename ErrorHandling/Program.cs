using System.Diagnostics;

int result = 0;

// Handle multiple exceptions(Inherit from Exception class)
try
{
    Console.WriteLine("Please enter a number");
    int num1 = int.Parse(Console.ReadLine() ?? "");
    int num2 = 2;
    result = num2 / num1;

}
catch (ArgumentNullException ex)
{
    Console.WriteLine("Please enter a valid number " + ex.Message);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Don't divide by zero please " + ex.Message);
}
catch (FormatException ex)
{
    Console.WriteLine("Enter a number please. " + ex.Message);
}
catch (OverflowException ex)
{
    Console.WriteLine("Number too high. " + ex.Message);
}

catch (Exception ex)
{
    Console.WriteLine("Error: " + ex.Message);
    // Only executed during debugging
    Debug.WriteLine(ex.ToString());
}

Console.WriteLine("Result: " + result);
Console.ReadKey();
