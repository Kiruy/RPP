using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ship2
{
    internal class SetShipsGeneric<T>
        where T : class
    {
        /// <summary>
        /// Массив объектов, которые храним
        /// </summary>
        private readonly List <T> _places;
        /// <summary>
        /// Количество объектов в массиве
        /// </summary>
        public int Count => _places.Count;
        private readonly int _maxCount;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="count"></param>
        public SetShipsGeneric(int count)
        {
            _maxCount = count;
            _places = new List<T>();
        }
        /// <summary>
        /// /// Добавление объекта в набор
        /// </summary>
        /// <param name="Ship">Добавляемый корабль</param>
        /// <returns></returns>
        public bool Insert(T Ship)
        {
            if (_maxCount >= Count)
            {

                _places.Add(Ship);
                return true;
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
            if (_maxCount < position)
            {
                return false;
            }
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
            if (_maxCount < position || position < -1)
            {
                return false;
            }
            if (_places[position] == null)
            {
                return false;
            }
            _places.RemoveAt(position);
            return true;
        }
        /// <summary>
        /// Получение объекта из набора по позиции
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public T this[int position]
        {
            get
            {
                if (_maxCount < position)
                {
                    MessageBox.Show("Выход за пределы списка!");
                    return null;
                }
                return _places[position];
            }
            set
            {
                if (_maxCount > position)
                {
                    _places[position] = value;
                }
            }
        }
        /// <summary>
        /// Проход по набору до первого пустого
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T> GetShips()
        {
            foreach (var ship in _places)
            {
                if (ship != null)
                {
                    yield return ship;
                }
                else
                {
                    yield break;
                }
            }
        }
    }
}