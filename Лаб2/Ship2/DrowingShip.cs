using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ship2
{
    internal class DrowingShip : IDrowingShip
    {
        public DrowingClassicShip Ship_w;

        public DrowingShip(DrowingClassicShip ship)
        {
            Ship_w = ship;
        }
        public float Step => Ship_w?.Ship?.Step ?? 0;

        public void DrawObject(Graphics g)
        {
            Ship_w?.DrawShip(g);
        }

        public (float Left, float Right, float Top, float Bottom) GetCurrentPosition()
        {
            return Ship_w?.GetCurrentPosition() ?? default;
        }

        public void MoveObject(Direction direction)
        {
            Ship_w?.MoveShip(direction);
        }

        public void SetObject(int x, int y, int width, int height)
        {
            Ship_w?.SetPosition(x, y, width, height);
        }
    }
}
