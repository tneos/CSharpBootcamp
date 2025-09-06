using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinqApp
{
    public class UniversityManager
    {
        public List<University> universities;
        public List<Student> students;

        // Initialize lists and add values(constructor)
        public UniversityManager()
        {
            universities = new List<University>();
            students = new List<Student>();

            universities.Add(new University { Id = 1, Name = "Yale" });
            universities.Add(new University { Id = 2, Name = "Cambridge" });

            students.Add(new Student { Id = 1, Name = "Thomas Smith", Gender = "male", Age = 22, UniversityId = 1 });
            students.Add(new Student { Id = 2, Name = "Susan Shannon", Gender = "female", Age = 21, UniversityId = 2 });
            students.Add(new Student { Id = 3, Name = "Rebecca Thomson", Gender = "female", Age = 24, UniversityId = 2 });
            students.Add(new Student { Id = 4, Name = "James Wilson", Gender = "male", Age = 20, UniversityId = 1 });
            students.Add(new Student { Id = 5, Name = "Tyler Norton", Gender = "male", Age = 19, UniversityId = 1 });
        }

        // Method that gets students based on gender
        public void MaleStudents()
        {
            IEnumerable<Student> maleStudents = from student in students where student.Gender == "male" select student;
            Console.WriteLine("Male students: ");

            foreach (Student student in maleStudents)
            {
                student.Print();
            }
        }

        public void FemaleStudents()
        {
            IEnumerable<Student> femaleStudents = from student in students where student.Gender == "female" select student;
            Console.WriteLine("Female students: ");

            foreach (Student student in femaleStudents)
            {
                student.Print();           }
        }
    }
}