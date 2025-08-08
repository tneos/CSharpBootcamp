namespace DelegatesAndEvents
{

    internal class Program
    {
        // Delegate declaration
        public delegate int Comparison<T>(T x, T y);

        public class Person
        {
            public int Age { get; set; }
            public string Name { get; set; }
        }

        public class PersonSorter
        {
            public void Sort(Person[] people, Comparison<Person> comparison)
            {
                for (int i = 0; i < people.Length; i++)
                {
                    for (int j = i + 1; j < people.Length; j++)
                    {
                        // Compare people[i] and people[j] using the provided comparison delegate
                        if (comparison(people[i], people[j]) > 0)
                        {
                            // Swap places
                            Person temp = people[i];
                            people[i] = people[j];
                            people[j] = temp;
                        }
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Person[] people = {
            new Person{Name = "Alice", Age = 32},
            new Person{Name = "Peter", Age = 52},
            new Person{Name = "Sam", Age = 29},
            new Person{Name = "Susan", Age = 39},
          };

            PersonSorter sorter = new PersonSorter();
            //sorter.Sort(people, CompareByAge);
            sorter.Sort(people, CompareByName);

            // Display people
            foreach (Person person in people)
            {
                Console.WriteLine($"{person.Name} {person.Age}");
            }

            Console.ReadKey();
        }

        static int CompareByAge(Person x, Person y)
        {
            return x.Age.CompareTo(y.Age);
        }

        static int CompareByName(Person x, Person y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
      

}

