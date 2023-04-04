using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ship2
{
    internal class MapWithSetShipsGeneric<T, U>
        where T : class, IDrowingClassicShip
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
        private readonly int _placeSizeHeight = 110;
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
        public int index = 0;
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
            foreach (var shp in _setShips.GetShips())
            {
                return _map.CreateMap(_pictureWidth, _pictureHeight, shp);
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
        /// Получение данных в виде строки
        /// </summary>
        /// <param name="sep"></param>
        /// <returns></returns>
        public string GetData(char separatorType, char separatorData)
        {
            string data = $"{_map.GetType().Name}{separatorType}";
            foreach (var car in _setShips.GetShips())
            {
                data += $"{car.GetInfo()}{separatorData}";
            }
            return data;
        }
        /// <summary>
        /// Загрузка списка из массива строк
        /// </summary>
        /// <param name="records"></param>
        public void LoadData(string[] records)
        {
            foreach (var rec in records)
            {
                _setShips.Insert(DrowingShip.Create(rec) as T);
            }
        }
        /// <summary>
        /// "Взбалтываем" набор, чтобы все элементы оказались в начале
        /// </summary>
        private void Shaking()
        {
            int j = _setShips.Count - 1;
            for (int i = 0; i < _setShips.Count; i++)
            {
                if (_setShips[i] == null)
                {
                    for (; j > i; j--)
                    {
                        var pln = _setShips[j];
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
            index = 0;
            foreach (var ship in _setShips.GetShips())
            {
                while (ship == null)
                {
                    ++index;
                    if (index == _setShips.Count)
                    {
                        return;
                    }
                }
                if (ship != null)
                {
                    ship.SetObject(5 + index / 5 * _placeSizeWidth + 5, index % 5 * _placeSizeHeight, 100, 100);
                    ++index;
                }

                ship.DrawObject(g);
            }
        }
    }
}
