namespace OldStyle;

class Program
{
    // Static field(defined outside Main)
    static int myResult;
    static void Main(string[] args)
    {


        myResult = AddValues(2, 12);
        Console.WriteLine("The result is: " + myResult);
    }



    // Define method and use it without creating an instance(static method)
    static int AddValues(int value1, int value2)
    {
        myResult = value1 + value2;
        return myResult;
    }

    static int SubtractValues(int value1, int value2)
    {
        myResult = value1 - value2;
        return myResult;
    }
}
