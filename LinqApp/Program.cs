using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqApp;
using Microsoft.VisualBasic;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 3, 6, 23, 24, 42 };
            // New instance of University Manager object
            UniversityManager um = new UniversityManager();
            um.MaleStudents();
            um.FemaleStudents();
            um.SortStudentsByAge();
            um.YaleStudents();
            Console.WriteLine("Please enter University id: 1: Yale, 2: Cambridge");
            string input = Console.ReadLine() ?? "";
            int inputAsInt = Convert.ToInt32(input);



            while (um.pickedUniStudents(inputAsInt) == 0)
            {
                Console.WriteLine("Enter valid value");
                input = Console.ReadLine() ?? "";
                inputAsInt = Convert.ToInt32(input);
            }
            
                um.pickedUniStudents(inputAsInt);
            

            OddNumbers(numbers);
            Console.ReadKey();

        }

        static void OddNumbers(int[] numbers)
        {
            // Linq statement
            IEnumerable<int> oddNumbers = from number in numbers where number % 2 != 0 select number;

            Console.WriteLine(oddNumbers);

            foreach (int i in oddNumbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}
