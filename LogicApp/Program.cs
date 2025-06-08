// See https://aka.ms/new-console-template for more information
Console.WriteLine("Logical and Relational operators");

int num1 = 5;
int num2 = 7;

// Relational operators < <= > >=
bool isGreater = num1 < num2;
Console.WriteLine(isGreater);

Console.WriteLine("Enter your age");

int age = int.Parse(Console.ReadLine() ?? "");

// Check age -- if adult , nested check for members
if (age < 18)
{
    Console.WriteLine("Sorry, not allowed entry");
    return;
}
else
{
    Console.WriteLine("Are you a member?");
    string id = Console.ReadLine() ?? "";

    if (age >= 18 && id == "yes")
        Console.WriteLine("Allowed entry");
    else
        Console.WriteLine("Sorry only members allowed");

}





