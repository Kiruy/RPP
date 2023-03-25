using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ship2
{
    internal class SetShipsGeneric<T>
        where T : class
    {
        /// <summary>
        /// Массив объектов, которые храним
        /// </summary>
        private readonly T[] _places;
        /// <summary>
        /// Количество объектов в массиве
        /// </summary>
        public int Count => _places.Length;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="count"></param>
        public SetShipsGeneric(int count)
        {
            _places = new T[count];
        }
        /// <summary>
        /// /// Добавление объекта в набор
        /// </summary>
        /// <param name="Ship">Добавляемый корабль</param>
        /// <returns></returns>
        public bool Insert(T Ship)
        {
            // TODO вставка в начало набора
            for (int i = 0; i < Count; i++)
            {
                if (_places[i] == null)
                {
                    _places[i] = Ship;
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Добавление объекта в набор на конкретную позицию
        /// </summary>
        /// <param name="Ship">Добавляемый корабль</param>
        /// <param name="position">Позиция</param>
        /// <returns></returns>
        public bool Insert(T Ship, int position)
        {
            // TODO проверка позиции
            // TODO проверка, что элемент массива по этой позиции пустой, если нет, то
            // проверка, что после вставляемого элемента вмассиве есть пустой элемент
            // сдвиг всех объектов, находящихся справа от позиции до первого пустого элемента
            // TODO вставка по позиции
            _places[position] = Ship;
            return true;
        }
        /// <summary>
        /// Удаление объекта из набора с конкретной позиции
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public bool Remove(int position)
        {
            // TODO проверка позиции
            // TODO удаление объекта из массива, присовив элементу массива значение null
            _places[position] = null;
            return true;
        }
        /// <summary>
        /// Получение объекта из набора по позиции
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public T Get(int position)
        {
            // TODO проверка позиции
            return _places[position];
        }
    }
}