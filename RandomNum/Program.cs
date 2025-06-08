// See https://aka.ms/new-console-template for more information
Console.WriteLine("Random Number");

// Create an instance of Random Class
Random random = new Random();

// It gives a random number between 1 and 10
int randomNumber = random.Next(1, 11);

Console.WriteLine("Guess the number");

string inputString = Console.ReadLine() ?? "";
int num1 = 0;

// Try to parse into a number, return 0 if not successful
bool isNumber = int.TryParse(inputString, out num1);

if (isNumber)
{
    if (num1 == randomNumber)
    {
        Console.WriteLine("You guessed right!");
    }
    else
    {
        Console.WriteLine("You guessed wrong. Try again.");
    }
}
else
    Console.WriteLine("Please enter a valid number");



Console.ReadKey();
