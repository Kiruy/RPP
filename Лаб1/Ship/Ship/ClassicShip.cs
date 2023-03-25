using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ship
{
    class ClassicShip
    {
        /// <summary>
        /// Максимальная скорость корабля
        /// </summary>
        public int MaxSpeed { private set; get; }
        /// <summary>
        /// Вес корабля
        /// </summary>
        public float Weight { private set; get; }
        /// <summary>
        /// Основной цвет корабля
        /// </summary>
        public Color MainColor { private set; get; }
        /// <summary>
        /// Шаг перемещения корабля
        /// </summary>
        public float Step => MaxSpeed * 100 / Weight;
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость корабля</param>
        /// <param name="weight">Вес корабля</param>
        /// <param name="mainColor">Основной цвет корабля</param>
        public void Init(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }
        
    }
}
