// See https://aka.ms/new-console-template for more information



// Declare an array (predefined length and data type)
// Add values into every index
int[] myIntArray = [5, 14, 22, 8, 31];

// Week days strings array
string[] weekDays = ["MON", "TUE", "WED", "THU", "FRI", "SAT", "SUN"];
Console.WriteLine(weekDays.Length);

// for (int i = 0; i < weekDays.Length; i++)
// { 
//     Console.WriteLine(weekDays[i]);
// }

foreach (string day in weekDays)
{
    Console.WriteLine(day);
}

// Two dimensional array
int[,] array2DDeclaration = new int[3, 3];
// Initialize two dimensional array
int[,] array2DInitialized = { { 1, 2 }, { 7, 9 } };
char[,] ticTacToe = { { 'x', 'o', 'o' }, { 'o', 'x', 'o' }, { 'o', 'o', 'x' } };
Console.WriteLine(array2DInitialized[1, 0]);
Console.WriteLine(ticTacToe[2, 2]);


