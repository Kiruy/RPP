using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ship2
{
    class BattleShip : ClassicShip
    {
        public Color DopColor { get; private set; }
        /// <summary>
        /// Признак наличия отсека с ракетами
        /// </summary>
        public bool Rocket { get; private set; }
        /// <summary>
        /// Пизнак наличия башни корабля </summary>
        public bool ShipTower { get; private set; }
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость корабля</param>
        /// <param name="weight">Вес корабля</param>
        /// <param name="mainColor">Основной цвет корабляя</param>
        public BattleShip(int maxSpeed, float weight, Color mainColor, Color dopColor, bool rocket, bool shipTower) :
            base(maxSpeed, weight, mainColor)
        {
            DopColor = dopColor;
            Rocket = rocket;
            ShipTower = shipTower;
        }
    }
}
