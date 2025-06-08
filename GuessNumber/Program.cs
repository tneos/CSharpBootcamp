// See https://aka.ms/new-console-template for more information

Random random = new Random();

int secretNumber = random.Next(1, 100);
int userGuess = 0;
int counter = 0;

Console.WriteLine("Guess the number between 1 - 100");

while (userGuess != secretNumber)
{
    userGuess = int.Parse(Console.ReadLine() ?? "");
    counter++;
    if (userGuess > secretNumber)
    {
        Console.WriteLine("Too high. Try again");
        
    }
    else if (userGuess < secretNumber)
    {
        Console.WriteLine("Too low. Try again");
        
    }
    else
    {
        Console.WriteLine("Congratulations! You guessed the secret number after " + counter + " attempts");
    }

}
