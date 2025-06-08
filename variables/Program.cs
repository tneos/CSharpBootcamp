// See https://aka.ms/new-console-template for more information


Console.WriteLine("Hello, World!");

// Declare variables
string myLine;
myLine = "This is my first day learning C#";

// Declare variable and assign a value
int myFavNumber = 12;

Console.WriteLine("Enter a whole number");


// Parse string into a number
int numToConvert = int.Parse(Console.ReadLine() ?? "");

// Implicit conversion
int myInt = 1432354532;
double myDouble = myInt;

long myLong = myInt;

// Explicit conversion(casting)
int myInt2 = (int)myLong;
int myInt3;
double myDouble3 = 12.5;
myInt3 = (int)myDouble3;

// Conversion Helpers (Parse and Convert)
string numberString = "123";
char myLetter = 'P';
string myLetterString = Convert.ToString(myLetter);
int result = int.Parse(numberString);

string myBoolString = "true";
bool myBool = Convert.ToBoolean(myBoolString);



// Interpolation
Console.WriteLine($"The number is {myDouble3}");
// String concatination
Console.WriteLine("The number is " + myDouble3);
// String formatting
Console.WriteLine("The number is {0} and my second number is {1}, and my line is {2}", myDouble3, myInt, myLine);

// Use/access variable
Console.WriteLine("Statement is: " + myBool, result);
Console.WriteLine( myInt3);
Console.WriteLine("You entered " + numToConvert);
Console.WriteLine(myLine);
Console.WriteLine(myFavNumber);


// Overwriting variable
myLine = "This is my second day learning C#";
Console.WriteLine(myLine);
