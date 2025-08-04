using System;

namespace DateTimeT
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2025, 8, 4);

            Console.WriteLine("Current date is {0}", dt);
            // Print today's date
            Console.WriteLine(DateTime.Today);
            // Print current time
            Console.WriteLine(DateTime.Now);
            // Print tomorrow's date
            Console.WriteLine(GetTomorrow());
            // Print day of the week
            Console.WriteLine("Today is: " + dt.DayOfWeek);
            // Print days of specific month
            int days = DateTime.DaysInMonth(1996, 2);
            Console.WriteLine("Days in Feb 1996: " + days);
            days = DateTime.DaysInMonth(1999, 2);
            Console.WriteLine("Days in Feb 1999: " + days);
            days = DateTime.DaysInMonth(2005, 2);
            Console.WriteLine("Days in Feb 2005: " + days);
            // Display time
            DateTime now = DateTime.Now;
            Console.WriteLine("The time at the moment is: " + now.ToShortTimeString());

            // Compare current date with a given one -- returns number of days
            Console.WriteLine("Write a date in this format: yyyy-mm-dd");
            string input = Console.ReadLine() ?? "";
            if (DateTime.TryParse(input, out dt))
            {
                Console.WriteLine(dt);
                TimeSpan daysPassed = now.Subtract(dt);
                Console.WriteLine("Days passed since: {0}", daysPassed.Days);
            }
            else
            {
                Console.WriteLine("Wrong input");
            }

            // Calculate days since user's birthday
            Console.WriteLine("Enter your birthday date in this format: yyyy-mm-dd");
            input = Console.ReadLine() ?? "";
            if (DateTime.TryParse(input, out dt))
            {
                TimeSpan daysSinceBirthday = now.Subtract(dt);
                Console.WriteLine("Days passed since your birthday: {0}", daysSinceBirthday.Days);
            }


        }

        static DateTime GetTomorrow()
        {
            return DateTime.Today.AddDays(1);
        }

        
      
    }
}
