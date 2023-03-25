using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ship2
{
    /// <summary>
    /// Делегат для передачи объекта-автомобиля
    /// </summary>
    /// <param name="ship"></param>
    public delegate void ShipDelegate(DrowingClassicShip ship);
}