using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ship2
{
    internal class DrowingShip : IDrowingClassicShip
    {
        public DrowingClassicShip Ship_w;

        public DrowingShip(DrowingClassicShip ship)
        {
            Ship_w = ship;
        }
        public float Step => Ship_w?.Ship?.Step ?? 0;
        public DrowingClassicShip GetShip => Ship_w;
        public Color GetColor => Ship_w.MainColor;

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
        public void SetObject1(int x, int y, int width, int height)
        {
            Ship_w?.SetPosition1(x, y, width, height);
        }
        public string GetInfo() => Ship_w?.GetDataForSave();
        public static IDrowingClassicShip Create(string data) => new DrowingShip(data.CreateDrawningShip());
        public bool Equals(IDrowingClassicShip other)
        {
            if (other == null)
            {
                return false;
            }
            
            var otherShip = other as DrowingShip;
            if (otherShip == null)
            {
                return false;
            }
            var ship = Ship_w.Ship;
            var otherShipShip = otherShip.Ship_w.Ship;
            if (ship.GetType() != otherShipShip.GetType())
            {
                return false;
            }
            if (ship.MaxSpeed != otherShipShip.MaxSpeed)
            {
                return false;
            }
            if (ship.Weight != otherShipShip.Weight)
            {
                return false;
            }
            if (ship.MainColor != otherShipShip.MainColor)
            {
                return false;
            }
            if (ship.GetType() != otherShipShip.GetType())
            {
                return false;
            }
            var A_Sip = Ship_w.Ship as BattleShip;
            var otherA_Ship = otherShip.Ship_w.Ship as BattleShip;
            if (A_Sip is BattleShip && otherA_Ship is BattleShip)
            {
                if (A_Sip.MaxSpeed != otherA_Ship.MaxSpeed)
                {
                    return false;
                }
                if (A_Sip.Weight != otherA_Ship.Weight)
                {
                    return false;
                }
                if (A_Sip.MainColor != otherA_Ship.MainColor)
                {
                    return false;
                }
                if (A_Sip.DopColor != otherA_Ship.DopColor)
                {
                    return false;
                }
                if (A_Sip.Rocket != otherA_Ship.Rocket)
                {
                    return false;
                }
                if (A_Sip.ShipTower != otherA_Ship.ShipTower)
                {
                    return false;
                }
                
            }
            return true;
        }
        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            DrowingShip plane = obj as DrowingShip;
            if (plane == null)
            {
                return false;
            }
            return Equals(plane);
        }
    }
}
