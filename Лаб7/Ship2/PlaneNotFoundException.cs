using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Ship2
{
    [Serializable]
    internal class PlaneNotFoundException : ApplicationException
    {
        public PlaneNotFoundException(int i) : base($"Не найден объект по позиции{ i}") { }
        public PlaneNotFoundException() : base() { }
        public PlaneNotFoundException(string message) : base(message) { }
        public PlaneNotFoundException(string message, Exception exception) : base(message, exception)
        { }
        protected PlaneNotFoundException(SerializationInfo info, StreamingContext contex) : base(info, contex) { }

    }
}