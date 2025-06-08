namespace WeatherStationSimulator;

class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Enter the amount of days to simulate: ");
        int days = int.Parse(Console.ReadLine() ?? "");
        // Create an array of int elements with length equal to number of days
        int[] temperature = new int[days];
        // Create an array of strings, with the following values of weather conditions
        string[] conditions = { "Sunny", "Rainy", "Cloudy" };
        // Array that holds weather conditions for a given day
        string[] weatherConditions = new string[days];

        // Create Random generator class
        Random random = new Random();

        Console.WriteLine($"Temperatures the last {days} days are: ");
        // Create array of random temperatures and random weather conditions
        for (int i = 0; i < days; i++)
        {
            temperature[i] = random.Next(-10, 40);
            // Condition for temperatures less than 4 degrees
            if (temperature[i] < 4)
            {
                weatherConditions[i] = "Snowy";
            }
            else
            {
                weatherConditions[i] = conditions[random.Next(conditions.Length)];
            }

            Console.WriteLine(temperature[i]);
        }

        double averageTemp = AverageTempCalculator(temperature);

        Console.WriteLine("The average temperature is : " + averageTemp);
        PrintConditions(weatherConditions, days);
        Console.WriteLine($"The minimum temperature is: {getMinTemp(temperature)}");
        Console.WriteLine($"The maximum temperature is: {getMaxTemp(temperature)}");
        Console.WriteLine($"Most common condition is: {mostCommonCondition(weatherConditions)}");
        // Same result with Min() and Max() of Math Class
        // Console.WriteLine($"The minimum temperature is: {temperature.Min()}");
        // Console.WriteLine($"The maximum temperature is: {temperature.Max()}");

    }

    static double AverageTempCalculator(int[] array)
    {
        double totals = 0;
        for (int i = 0; i < array.Length; i++)
        {
            totals = totals + array[i];

        }
        double avgTemp = Math.Round(totals / array.Length, 2);
        return avgTemp;
    }

    static void PrintConditions(string[] array, int days)
    {
        Console.WriteLine($"Weather conditions in the last {days} days are: ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }

    static int getMinTemp(int[] array)
    {
        int minTemp = array[0];

        // Solution with for loop
        //int temp;
        // for (int i = 0; i < array.Length; i++)
        // {
        //     temp = array[i];
        //     if (temp < minTemp)
        //     {
        //         minTemp = temp;
        //     }
        // }

        // Solution with foreach loop
        foreach (int temp in array)
        {
            if (temp < minTemp)
            {
                minTemp = temp;
            }
        }

        return minTemp;
    }

    static int getMaxTemp(int[] array)
    {
        int maxTemp = array[0];
        int temp;
        for (int i = 0; i < array.Length; i++)
        {
            temp = array[i];
            if (temp > maxTemp)
            {
                maxTemp = temp;
            }
        }

        return maxTemp;
    }

    static string mostCommonCondition(string[] array)
    {
        int count = 0;
        // Condition at index 0 most common before loop
        string mostCommon = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            int tempCount = 0;
            for (int j = 0; j < array.Length; j++)
            {
                if (array[j] == array[i])
                {
                    tempCount++;
                }
            }
            if (tempCount > count)
            {
                count = tempCount;
                mostCommon = array[i];
            }
        }

        return mostCommon;
    }
    
}
