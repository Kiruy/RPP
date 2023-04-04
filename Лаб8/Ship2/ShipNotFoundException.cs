using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Ship2
{
    [Serializable]
    internal class ShipNotFoundException : ApplicationException
    {
        public ShipNotFoundException(int i) : base($"Не найден объект по позиции{ i}") { }
        public ShipNotFoundException() : base() { }
        public ShipNotFoundException(string message) : base(message) { }
        public ShipNotFoundException(string message, Exception exception) : base(message, exception)
        { }
        protected ShipNotFoundException(SerializationInfo info, StreamingContext contex) : base(info, contex) { }

    }
}