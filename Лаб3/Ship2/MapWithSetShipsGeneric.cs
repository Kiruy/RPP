using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ship2
{
    internal class MapWithSetShipsGeneric<T, U>
        where T : class, IDrowingShip
        where U : AbstractMap
    {
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private readonly int _pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private readonly int _pictureHeight;
        /// <summary>
        /// Размер занимаемого объектом места (ширина)
        /// </summary>
        private readonly int _placeSizeWidth = 240;
        /// <summary>
        /// Размер занимаемого объектом места (высота)
        /// </summary>
        private readonly int _placeSizeHeight = 40;
        /// <summary>
        /// Набор объектов
        /// </summary>
        private readonly SetShipsGeneric<T> _setShips;
        /// <summary>
        /// Карта
        /// </summary>
        private readonly U _map;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="picWidth"></param>
        /// <param name="picHeight"></param>
        /// <param name="map"></param>
        public MapWithSetShipsGeneric(int picWidth, int picHeight, U map)
        {
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            _setShips = new SetShipsGeneric<T>(width * height);
            _pictureWidth = picWidth;
            _pictureHeight = picHeight;
            _map = map;
        }
        /// <summary>
        /// Перегрузка оператора сложения
        /// </summary>
        /// <param name="map"></param>
        /// <param name="Ship"></param>
        /// <returns></returns>
        public static bool operator +(MapWithSetShipsGeneric<T, U> map, T Ship)
        {
            return map._setShips.Insert(Ship);
        }
        /// <summary>
        /// Перегрузка оператора вычитания
        /// </summary>
        /// <param name="map"></param>
        /// <param name="position"></param>
        /// <returns></returns>
        public static bool operator -(MapWithSetShipsGeneric<T, U> map, int position)
        {
            return map._setShips.Remove(position);
        }
        /// <summary>
        /// Вывод всего набора объектов
        /// </summary>
        /// <returns></returns>
        public Bitmap ShowSet()
        {
            Bitmap bmp = new Bitmap(_pictureWidth, _pictureHeight);
            Graphics gr = Graphics.FromImage(bmp);
            DrawBackground(gr);
            DrawShips(gr);
            return bmp;
        }
        /// <summary>
        /// Просмотр объекта на карте
        /// </summary>
        /// <returns></returns>
        public Bitmap ShowOnMap()
        {
            Shaking();
            for (int i = 0; i < _setShips.Count; i++)
            {
                var shp = _setShips.Get(i);
                if (shp != null)
                {
                    return _map.CreateMap(_pictureWidth, _pictureHeight, shp);
                }
            }
            return new Bitmap(_pictureWidth, _pictureHeight);
        }
        /// <summary>
        /// Перемещение объекта по крате
        /// </summary>
        /// <param name="direction"></param>
        /// <returns></returns>
        public Bitmap MoveObject(Direction direction)
        {
            if (_map != null)
            {
                return _map.MoveObject(direction);
            }
            return new Bitmap(_pictureWidth, _pictureHeight);
        }
        /// <summary>
        /// "Взбалтываем" набор, чтобы все элементы оказались в начале
        /// </summary>
        private void Shaking()
        {
            int j = _setShips.Count - 1;
            for (int i = 0; i < _setShips.Count; i++)
            {
                if (_setShips.Get(i) == null)
                {
                    for (; j > i; j--)
                    {
                        var pln = _setShips.Get(j);
                        if (pln != null)
                        {
                            _setShips.Insert(pln, i);
                            _setShips.Remove(j);
                            break;
                        }
                    }
                    if (j <= i)
                    {
                        return;
                    }
                }
            }
        }
        /// <summary>
        /// Метод отрисовки фона
        /// </summary>
        /// <param name="g"></param>
        private void DrawBackground(Graphics g)
        {
            Pen pen = new Pen(Color.Purple, 5);
            for (int i = 0; i < _pictureWidth / _placeSizeWidth; i++)
            {
                for (int j = 0; j < _pictureHeight / _placeSizeHeight + 1; ++j)
                {
                    //линия рамзетки места
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight, i *
                   _placeSizeWidth + _placeSizeWidth / 2, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth + (_placeSizeWidth / 2), 0, i * _placeSizeWidth + (_placeSizeWidth / 2),
                (_pictureHeight / _placeSizeHeight) * _placeSizeHeight);
            }
        }
        /// <summary>
        /// Метод прорисовки объектов
        /// </summary>
        /// <param name="g"></param>
        private void DrawShips(Graphics g)
        {
            for (int i = 0; i < _setShips.Count; i++)
            {
                while (_setShips == null)
                {
                    i++;
                    if (i == _setShips.Count)
                    {
                        return;
                    }
                }
                if (_setShips.Get(i) != null)
                {
                    _setShips.Get(i).SetObject(4 + i / 4 * _placeSizeWidth + 4, i % 4 *
               _placeSizeHeight, 100, 100);
                }
                // TODO установка позиции
                _setShips.Get(i)?.DrawObject(g);
            }
        }
    }
}
