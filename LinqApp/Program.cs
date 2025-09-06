using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqApp;

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
