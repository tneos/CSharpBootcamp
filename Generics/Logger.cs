using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generics
{
    public class Logger
    {
        // Generic type method
        public void Log<T>(T message)
        {
            Console.WriteLine(message?.ToString());
        }
    }
}