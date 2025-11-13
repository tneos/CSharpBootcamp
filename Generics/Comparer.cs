using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generics
{
    public class Comparer
    {
        // Constraint for Generic method
        public static bool AreEqual<T>(T first, T second) where T:class
        {
            return first == second;
        }
    }
}