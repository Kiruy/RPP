using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ship2
{
    public class DrowingClassicShip
    {
        /// <summary>
        /// Класс-сущность
        /// </summary>
        public ClassicShip Ship { protected set; get; }
        /// <summary>
        /// Левая координата отрисовки корабля
        /// </summary>
        protected float _startPosX;
        /// <summary>
        /// Правая кооридната отрисовки корабля
        /// </summary>
        protected float _startPosY;
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
        private readonly int ClassicShipWidth = 100;
        /// <summary>
        /// Высота отрисовки корабля
        /// </summary>
        private readonly int ClassicShipHeight = 40;
        /// <summary>
        /// Инициализация свойств
        /// </summary>
        /// <param name="maxSpeed">Скорость корабля</param>
        /// <param name="weight">Вес корабля</param>
        /// <param name="mainColor">Основной цвет корабля</param>
        public DrowingClassicShip(int maxSpeed, float weight, Color mainColor)
        {
            Ship = new ClassicShip(maxSpeed, weight, mainColor);
        }
        protected DrowingClassicShip(int maxSpeed, float weight, Color mainColor, int сlassicShipWidth, int сlassicShipHeight) :
            this (maxSpeed, weight, mainColor)
        {
            this.ClassicShipWidth = сlassicShipWidth;
            this.ClassicShipHeight = сlassicShipHeight;
        }
        /// <summary>
        /// Установка позиции корабля
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
        public void SetPosition1(int x, int y, int width, int height)
        {
            if ((x >= 0) && (y >= 0) && (x < width - ClassicShipWidth + 10) && (y < height - ClassicShipHeight + 10))
            {
                _startPosX = x;
                _startPosY = y;
                _pictureWidth = width;
                _pictureHeight = height;
            }
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
        /// Отрисовка корабля
        /// </summary>
        /// <param name="g"></param>
        public virtual void DrawShip(Graphics g)
        {
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(Ship.MainColor);

            int _startPosXInt = (int)_startPosX + 20;
            int _startPosYInt = (int)_startPosY + 5;
            //двигатель
            g.FillRectangle(myBrush, _startPosX + 5, _startPosYInt + 9, 5, 10);
            //корпус
            g.FillRectangle(myBrush, _startPosX + 10, _startPosYInt, 80, 30);
            //нос корабля
            Point pointNose1 = new Point(_startPosXInt + 70, _startPosYInt);
            Point pointNose2 = new Point(_startPosXInt + 70, _startPosYInt + 30);
            Point pointNose3 = new Point(_startPosXInt + 86, _startPosYInt + 14);

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
        public (float Left, float Right, float Top, float Bottom) GetCurrentPosition()
        {
            return (_startPosX, _startPosY, _startPosX + ClassicShipWidth, _startPosY + ClassicShipHeight);
        }
    }
}