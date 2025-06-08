// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to the Adventure Game!");
Console.WriteLine("Enter your character's name: ");
string playerName = Console.ReadLine() ?? "";
Console.WriteLine("Choose your character type (Warrior, Wizard, Archer)");
string characterType = Console.ReadLine() ?? "";

Console.WriteLine($"You, {playerName} the {characterType} find yourself at a dark forest");
Console.WriteLine("Do you enter the forest or camp outside? (Enter/Camp)");

string choice1 = Console.ReadLine() ?? "";
if (choice1.ToLower() == "enter")
{
    Console.WriteLine("You bravely entered the forest");
}
else
{
    Console.WriteLine("You decided to camp out and wait for daylight.");
}

bool gameContinues = true;

while (gameContinues)
{
    Console.WriteLine("You come to a fork in the road. Go left or right?");
    string direction = Console.ReadLine() ?? "";

    if (direction.ToLower() == "left")
    {
        Console.WriteLine("You found the treasure chest!");
        gameContinues = false;
    }
    else
    {
        Console.WriteLine("You encounter a wild beast!");
        Console.WriteLine("Fight or flee? (fight/flee)");
        string fightChoice = Console.ReadLine() ?? "";
        if (fightChoice.ToLower() == "fight")
        {
            Random random = new Random();
            int luck = random.Next(1, 11);
            if (luck > 5)
            {
                Console.WriteLine("You beat the wild beast!");
                if (luck > 8)
                {
                    Console.WriteLine("The wild beast dropped a treasure!");
                }
            }
            else
            {
                Console.WriteLine("The beast attacked you while you were not expecting it");
                Console.WriteLine("It rammed its tasks into your chest and you bleed out");
                gameContinues = false;
            }
        }
    }
}

Console.WriteLine("Game Over!");
Console.WriteLine("Thank you for playing the game");

Console.ReadKey();


