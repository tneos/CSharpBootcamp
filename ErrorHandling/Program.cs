using System.Diagnostics;

int result = 0;

try
{
    Console.WriteLine("Please enter a number");
    int num1 = 0;
    int num2 = 2;
    result = num2 / num1;

}
catch (Exception ex)
{
    Console.WriteLine("Error: " + ex.Message);
    // Only executed during debugging
    Debug.WriteLine(ex.ToString());
}

Console.WriteLine("Result: " + result);
Console.ReadKey();
