using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ship
{
    class DrowingClassicShip
    {
        /// <summary>
        /// Класс-сущность
        /// </summary>
        public ClassicShip Ship { private set; get; }
        /// <summary>
        /// Левая координата отрисовки корабля
        /// </summary>
        private float _startPosX;
        /// <summary>
        /// Правая кооридната отрисовки корабля
        /// </summary>
        private float _startPosY;
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private int? _pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private int? _pictureHeight;
        /// <summary>
        /// Ширина отрисовки корабля
        /// </summary>
        /// 
        private readonly int ClassicShipWidth = 100;
        /// <summary>
        /// Высота отрисовки корабля
        /// </summary>
        private readonly int ClassicShipHeight = 100;
        /// <summary>
        /// Инициализация свойств
        /// </summary>
        /// <param name="maxSpeed">Скорость корабля</param>
        /// <param name="weight">Вес корабля</param>
        /// <param name="mainColor">Цвет корабля</param>
        public void Init(int maxSpeed, float weight, Color mainColor)
        {
            Ship = new ClassicShip();
            Ship.Init(maxSpeed, weight, mainColor);
        }
        /// <summary>
        /// Установка стартовой позиции корабля
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="width">Ширина картинки</param>
        /// <param name="height">Высота картинки</param>
        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }
        /// <summary>
        /// Изменение направления перемещения
        /// </summary>
        /// <param name="direction">Направление</param>
        public void MoveShip(Direction direction)
        {
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + Ship.Step < _pictureWidth - ClassicShipWidth)
                    {
                        _startPosX += Ship.Step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - Ship.Step > 0)
                    {
                        _startPosX -= Ship.Step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - Ship.Step > 0)
                    {
                        _startPosY -= Ship.Step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + Ship.Step < _pictureHeight - ClassicShipHeight)
                    {
                        _startPosY += Ship.Step;
                    }
                    break;
            }
        }
        /// <summary>
        /// Отрисовка нашего корабля
        /// </summary>
        /// <param name="g"></param>
        public void DrawShip(Graphics g)
        {
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(Ship.MainColor);
            int _startPosXInt = (int)_startPosX;
            int _startPosYInt = (int)_startPosY;
            //двигатель
            g.FillRectangle(myBrush, _startPosX, _startPosY + 49, 5, 10);
            //корпус
            g.FillRectangle(myBrush, _startPosX + 5, _startPosY + 40, 80, 30);
            //нос корабля
            Point pointNose1 = new Point(_startPosXInt + 85, _startPosYInt + 40);
            Point pointNose2 = new Point(_startPosXInt + 85, _startPosYInt + 70);
            Point pointNose3 = new Point(_startPosXInt + 105, _startPosYInt + 55);

            Point[] PointsNose ={
                 pointNose1,
                 pointNose2,
                 pointNose3,
             };
            g.FillPolygon(myBrush, PointsNose);
        }
        /// <summary>
        /// Смена границ формы отрисовки
        /// </summary>
        /// <param name="width">Ширина картинки</param>
        /// <param name="height">Высота картинки</param>
        public void ChangeBorders(int width, int height)
        {
            _pictureWidth = width;
            _pictureHeight = height;
            if (_pictureWidth <= ClassicShipWidth || _pictureHeight <= ClassicShipHeight)
            {
                _pictureWidth = 0;
                _pictureHeight = 0;
                return;
            }
            if (_startPosX + ClassicShipWidth > _pictureWidth)
            {
                _startPosX = _pictureWidth.Value - ClassicShipWidth;
            }
            if (_startPosY + ClassicShipHeight > _pictureHeight)
            {
                _startPosY = _pictureHeight.Value - ClassicShipHeight;
            }
        }
    }
}