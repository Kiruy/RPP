using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ship2
{
    internal class MapAlreadyExistException : Exception
    {
        public MapAlreadyExistException() : base("Такая карта уже существует!")
        { }
    }
}
