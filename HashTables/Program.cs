using System;
using System.Collections;

namespace HashTables
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create hash table
            Hashtable studentsTable = new Hashtable();

           
            // New instances of class Student
            Student stud1 = new Student(1, "Maria", 67);
            Student stud2 = new Student(2, "James", 77);
            Student stud3 = new Student(3, "John", 62);
            Student stud4 = new Student(4, "Tim", 92);

            // Add students to hash table
            studentsTable.Add(stud1.Id, stud1);
            studentsTable.Add(stud2.Id, stud2);
            studentsTable.Add(stud3.Id, stud3);
            studentsTable.Add(stud4.Id, stud4);

            // Fetch entry from table
            Student storedStudent1 = (Student)studentsTable[3]!;
            Console.WriteLine("Student ID:{0}, Name:{1}, GPA:{2}", storedStudent1.Id, storedStudent1.Name, storedStudent1.GPA);

            // Get all entries from table
            foreach (DictionaryEntry entry in studentsTable)
            {
                Student temp = (Student)entry.Value!;
                Console.WriteLine("Student ID:{0}", temp.Id);
                Console.WriteLine("Student ID:{0}", temp.Name);
                Console.WriteLine("Student ID:{0}", temp.GPA);
            }

            // Alternatively -- variable type Student, skip casting step
            // foreach (Student value in studentsTable.Values)
            // {
            //    Console.WriteLine("Student ID:{0}", value.Id);
            //    Console.WriteLine("Student ID:{0}", value.Name);
            //    Console.WriteLine("Student ID:{0}", value.GPA); 
            // }
        }
    }
}
