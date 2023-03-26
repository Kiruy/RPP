using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ship2
{
    internal abstract class AbstractMap
    {
        private IDrowingShip _drowingShip = null;
        protected int[,] _map = null;
        protected int _x;
        protected int _y;
        protected int _width;
        protected int _height;
        protected float _size_x;
        protected float _size_y;
        protected readonly Random _random = new Random();
        protected readonly int _freeRoad = 0;
        protected readonly int _barrier = 1;

        public Bitmap CreateMap(int width, int height, IDrowingShip drowingShip)
        {
            _width = width;
            _height = height;
            _drowingShip = drowingShip;
            GenerateMap();
            while (!SetObjectOnMap())
            {
                GenerateMap();
            }
            return DrawMapWithObject();
        }
        public Bitmap MoveObject(Direction direction)
        {
            // TODO проверка, что объект может переместится в требуемом направлении
            switch (direction)
            {
                case Direction.Up:
                    if (CheckBarrier(_x, _y - (int)_drowingShip.Step))
                    {
                        _y -= (int)_drowingShip.Step;
                        _drowingShip.MoveObject(direction);
                    }
                    break;
                case Direction.Down:
                    if (CheckBarrier(_x, _y + (int)_drowingShip.Step))
                    {
                        _y += (int)_drowingShip.Step;
                        _drowingShip.MoveObject(direction);
                    }
                    break;
                case Direction.Left:
                    if (CheckBarrier(_x - (int)_drowingShip.Step, _y))
                    {
                        _x -= (int)_drowingShip.Step;
                        _drowingShip.MoveObject(direction);
                    }
                    break;
                case Direction.Right:
                    if (CheckBarrier(_x + (int)_drowingShip.Step, _y))
                    {
                        _x += (int)_drowingShip.Step;
                        _drowingShip.MoveObject(direction);
                    }
                    break;
            }

            // TODO проверка, что объект может переместится в требуемом направлении
            return DrawMapWithObject();
        }
        private bool SetObjectOnMap()
        {
            if (_drowingShip == null || _map == null)
            {
                return false;
            }
            int x = _random.Next(0, _width);
            int y = _random.Next(0, _height);
            _drowingShip.SetObject1(x, y, _width, _height);
            _x = x;
            _y = y;
            if (CheckBarrier(x, y))
            {
                return true;
            }

            // TODO првоерка, что объект не "накладывается" на закрытые участки
            return false;
        }
        private Bitmap DrawMapWithObject()
        {
            Bitmap bmp = new Bitmap(_width, _height);
            if (_drowingShip == null || _map == null)
            {
                return bmp;
            }
            Graphics gr = Graphics.FromImage(bmp);
            for (int i = 0; i < _map.GetLength(0); ++i)
            {
                for (int j = 0; j < _map.GetLength(1); ++j)
                {
                    if (_map[i, j] == _freeRoad)
                    {
                        DrawRoadPart(gr, i, j);
                    }
                    else if (_map[i, j] == _barrier)
                    {
                        DrawBarrierPart(gr, i, j);
                    }
                }
            }
            _drowingShip.DrawObject(gr);
            return bmp;
        }
        private bool CheckBarrier(int _x_, int _y_)
        {
            for (int i = 0; i < _map.GetLength(0); ++i)
            {
                for (int j = 0; j < _map.GetLength(1); ++j)
                {
                    if (_map[i, j] == _barrier)
                    {
                        if ((_x_ < i * _size_x) && (i * _size_x < (_x_ + 120)))
                        {
                            if (((_y_) < j * _size_y) && (j * _size_y < (_y_ + 100)))
                            {
                                return false;
                            }
                        }
                        if ((_x_ < i * _size_x + 10) && (i * _size_x + 10 < (_x_ + 120)))
                        {
                            if (((_y_) < j * _size_y + 5) && (j * _size_y + 5 < (_y_ + 100)))
                            {
                                return false;
                            }
                        }
                    }
                }
            }
            return true;
        }
        protected abstract void GenerateMap();
        protected abstract void DrawRoadPart(Graphics g, int i, int j);
        protected abstract void DrawBarrierPart(Graphics g, int i, int j);
    }
}
