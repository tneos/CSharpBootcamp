// See https://aka.ms/new-console-template for more information

int currentScore;
int sum = 0;
int counter = 0;

do
{
    Console.WriteLine("Enter your students score. Enter -1 to finish");
    currentScore = int.Parse(Console.ReadLine() ?? "");
    if (currentScore != -1)
    {
        sum = sum + currentScore;
        counter++;
    }
    
    // Run the loop as long as user adds a score
} while (currentScore != -1);

// Calculate average
int average = sum / counter;

Console.WriteLine("The average is: " + average);
