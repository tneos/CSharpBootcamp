using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinqApp
{
    public class Student
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Gender { get; set; }
        public int Age { get; set; }

        // Foreign Key
        public int UniversityId { get; set; }

        public void Print()
        {
            Console.WriteLine("Student {0} with Id {1}, Gender {2} and age {3} from University with Id {4}",Name,  Id, Gender, Age, UniversityId);
        }

    }
}