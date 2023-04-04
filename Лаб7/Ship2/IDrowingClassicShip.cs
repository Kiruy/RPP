using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Ship2
{
    internal interface IDrowingClassicShip
    {
        /// <summary>
        /// Шаг перемещения корабля
        /// </summary>
        float Step { get; }
        /// <summary>
        /// Установка позиции корабля
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="width">Ширина полотна</param>
        /// <param name="height">Высота полотна</param>
        void SetObject(int x, int y, int width, int height);
        void SetObject1(int x, int y, int width, int height);
        /// <summary>
        /// Изменение направления пермещения корабля
        /// </summary>
        /// <param name="direction">Направление</param>
        void MoveObject(Direction direction);
        /// <summary>
        /// Отрисовка объекта
        /// </summary>
        /// <param name="g"></param>
        void DrawObject(Graphics g);
        /// <summary>
        /// Получение текущей позиции объекта
        /// </summary>
        /// <returns></returns>
        (float Left, float Right, float Top, float Bottom) GetCurrentPosition();
        /// <summary>
        /// Получение информации по объекту
        /// </summary>
        /// <returns></returns>
        string GetInfo();
    }
}
