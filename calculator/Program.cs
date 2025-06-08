// See https://aka.ms/new-console-template for more information

// Prints out string
using System.Globalization;

Console.WriteLine("Calculator using C#");

Console.WriteLine("Enter first number");

// Takes user input and store it
double input1 = double.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Enter second number");

// Takes user input and store it
double input2 = double.Parse(Console.ReadLine() ?? "");

// Perform addition and print result to the console
double addition = Math.Round(input1 + input2, 2);
// string concatination
//Console.WriteLine("The result of adding " + input1 + "+" + input2 + "=" + addition);
// string interpolation
Console.WriteLine($"The result of adding  {input1} + {input2}  =  {addition}");

int num1 = 0;
int num2 = 0;
Console.WriteLine("Enter the first number");
bool validNum1 = int.TryParse(Console.ReadLine() ?? "", out num1);
Console.WriteLine("Enter the second number");
bool validNum2 = int.TryParse(Console.ReadLine() ?? "", out num2);
Console.WriteLine("Choose an operation: +, -, *, /");
char operation = char.Parse(Console.ReadLine() ?? "");
int result;




    switch (operation)
    {
        case '+':
            result = num1 + num2;
            Console.WriteLine($"{num1} + {num2} = {result}");
            break;
        case '-':
            result = num1 - num2;
            Console.WriteLine($"{num1} - {num2} = {result}");
            break;
        case '*':
            result = num1 * num2;
            Console.WriteLine($"{num1} * {num2} = {result}");
            break;
        case '/':
        if (num2 == 0)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
            break;
            }
            result = num1 / num2;
            Console.WriteLine($"{num1} / {num2} = {result}");
            break;

        default:
            Console.WriteLine("Invalid operation. Please choose +, -, *, or /.");
            break;


    }



