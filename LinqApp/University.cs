using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinqApp
{
    public class University
    {
        public int Id { get; set; }
        public required string Name { get; set; }

        public void Print()
        {
            Console.WriteLine("University {0} with id {1}", Name, Id);
        }
    }
}