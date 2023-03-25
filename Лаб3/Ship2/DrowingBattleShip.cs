using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ship2
{
    internal class DrowingBattleShip : DrowingClassicShip
    {
        public DrowingBattleShip(int maxSpeed, float weight, Color mainColor, Color dopColor, bool rocket, bool shipTower) :
            base(maxSpeed, weight, mainColor)
        {
            Ship = new BattleShip(maxSpeed, weight, mainColor, dopColor, rocket, shipTower);
        }
        public override void DrawShip(Graphics g)
        {
            if (!(Ship is BattleShip battleShip))
            {
                return;
            }
            System.Drawing.SolidBrush myBrush2 = new System.Drawing.SolidBrush(battleShip.DopColor);
            int _startPosXInt = (int)_startPosX + 10;
            int _startPosYInt = (int)_startPosY;
           
            base.DrawShip(g);
            //башня корабля
            if (battleShip.ShipTower)
            {
                g.FillRectangle(myBrush2, _startPosX + 60, _startPosY + 10, 20, 20);
                g.FillRectangle(myBrush2, _startPosX + 80, _startPosY + 14, 15, 3);
                g.FillRectangle(myBrush2, _startPosX + 80, _startPosY + 22, 15, 3);
                g.FillRectangle(myBrush2, _startPosX + 4, _startPosY + 13, 7, 12);
            };
            //отсек с ракетами
            if (battleShip.Rocket)
            {
                g.FillRectangle(myBrush2, _startPosX + 20, _startPosY + 10, 15, 2);
                g.FillRectangle(myBrush2, _startPosX + 20, _startPosY + 15, 15, 2);
                g.FillRectangle(myBrush2, _startPosX + 20, _startPosY + 20, 15, 2);
                g.FillRectangle(myBrush2, _startPosX + 20, _startPosY + 25, 15, 2);
            }
        }
    }
}
