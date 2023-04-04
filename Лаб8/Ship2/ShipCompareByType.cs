using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ship2
{
    internal class ShipCompareByType : IComparer<IDrowingClassicShip>
    {
        public int Compare(IDrowingClassicShip x, IDrowingClassicShip y)
        {
            if (x == null && y == null)
            {
                return 0;
            }
            if (x == null && y != null)
            {
                return 1;
            }
            if (x != null && y == null)
            {
                return -1;
            }
            var xShip = x as DrowingShip;
            var yShip = y as DrowingShip;
            if (xShip == null && yShip == null)
            {
                return 0;
            }
            if (xShip == null && yShip != null)
            {
                return 1;
            }
            if (xShip != null && yShip == null)
            {
                return -1;
            }
            if (xShip.GetShip.GetType().Name != yShip.GetShip.GetType().Name)
            {
                if (xShip.GetShip.GetType().Name == "DrowingClassicShip")
                {
                    return -1;
                }
                return 1;
            }
            var speedCompare = xShip.GetShip.Ship.MaxSpeed.CompareTo(yShip.GetShip.Ship.MaxSpeed);
            if (speedCompare != 0)
            {
                return speedCompare;
            }
            return xShip.GetShip.Ship.Weight.CompareTo(yShip.GetShip.Ship.Weight);
        }

    }
}
