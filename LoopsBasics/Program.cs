// See https://aka.ms/new-console-template for more information
Console.WriteLine("Rocket Landing Simulation");



string rocketShape = ">=========>";



// Count up to 10
for (int i = 0; i < 10; i++)
{
    Console.Clear();
    Console.WriteLine("Counter is " + i);
    Console.WriteLine(rocketShape);
    rocketShape = "\n" + rocketShape;
    Thread.Sleep(2000);

}
Console.WriteLine("The rocket has landed");




// Count down to 0
// for (int i = 10; i > 0; i--)
// {
//     Console.WriteLine("J is: " + i);
//     Thread.Sleep(1000);
// }
