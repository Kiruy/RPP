using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ship2
{
    internal class DocksAlreadyHaveException : Exception
    {
        public DocksAlreadyHaveException() : base("В доках уже есть такой корабль")
        { }
    }
}
