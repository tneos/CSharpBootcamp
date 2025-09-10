using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Globalization;
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
                student.Print();
            }
        }

        // Sorting method
        public void SortStudentsByAge()
        {
            var sortedStudents = from student in students orderby student.Age select student;

            Console.WriteLine("Students sorted by Age:");

            foreach (Student student in sortedStudents)
            {
                student.Print();
            }
        }

        // Filter students based on university
        public void YaleStudents()
        {
            IEnumerable<Student> yaleStudents = from student in students
                                                join university in universities on student.UniversityId equals university.Id
                                                where university.Name == "Yale"
                                                select student;

            Console.WriteLine("Students from Yale University: ");
            foreach (Student student in yaleStudents)
            {
                student.Print();
            }
        }

        // Filter students based on university id input by the user
        public int pickedUniStudents(int id)
        {
            IEnumerable<Student> pickedUniStudents = from student in students
                                                     join university in universities on student.UniversityId equals university.Id
                                                     where university.Id == id
                                                     select student;

            Console.WriteLine("Students from selected University: ");

            //Console.WriteLine(pickedUniStudents.Count());
            foreach (Student student in pickedUniStudents)
            {
                student.Print();
            }

            return pickedUniStudents.Count();

        }

        // Method that creates a new list out of students and universities ones
        public void StudentAndUniversityNameCollection()
        {
            var newCollection = from student in students
                                join university in universities on student.UniversityId equals university.Id
                                orderby student.Name
                                select new { StudentName = student.Name, UniversityName = university.Name };

            Console.WriteLine("New Collection: ");

            foreach (var col in newCollection)
            {
                Console.WriteLine("Student {0} from {1} University", col.StudentName, col.UniversityName);
            }
        }
    }
}