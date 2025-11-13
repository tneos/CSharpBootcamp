using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generics
{
    internal interface IEntity
    {
        int Id { get; }
    }
    // Generic type that has to implement IEntity interface
    internal class Repository<T> where T: IEntity
    {
        private List<T> values = new List<T>();

        public void Add(T entity)
        {
            values.Add(entity);
        }
    }
}