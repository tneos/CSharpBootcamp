// See https://aka.ms/new-console-template for more information

// Quiz App
// Basic version without loops or functions

string question1 = "What is the capital of Norway?";
string answer1 = "Oslo";

string question2 = "What is the name of the lead singer of Cure";
string answer2 = "Robert Smith";

string question3 = "What year was the French Revolution?";
string answer3 = "1789";

int score = 0;

Console.WriteLine(question1);
string userAnswer1 = Console.ReadLine() ?? "";

if (userAnswer1.Trim().ToLower() == answer1.ToLower())
{
    Console.WriteLine("Correct!");
    score++;
}
else
{
    Console.WriteLine("Wrong, the correct answer is: " + answer1);
}

Console.WriteLine(question2);
string userAnswer2 = Console.ReadLine() ?? "";
if (userAnswer2.Trim().ToLower() == answer2.ToLower())
{
    Console.WriteLine("Correct!");
    score++;
}
else
{
    Console.WriteLine("Wrong, the correct answer is: " + answer2);
}
Console.WriteLine(question3);
string userAnswer3 = Console.ReadLine() ?? "";
if (userAnswer3.Trim().ToLower() == answer3.ToLower())
{
    Console.WriteLine("Correct!");
    score++;
}
else
{
    Console.WriteLine("Wrong, the correct answer is: " + answer3);
}
if (score == 3)
{
    Console.WriteLine($"Quiz completed! Congratulations! You've got all the answers correct. Your final score is {score}/3");
}
else 
   Console.WriteLine($"Quiz completed! Your final score is {score}/3");

Console.ReadKey();
