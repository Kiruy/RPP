using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ship2
{
    internal class MapsCollection
    {
        /// <summary>
        /// Словарь (хранилище) с картами
        /// </summary>
        readonly Dictionary<string, MapWithSetShipsGeneric<DrowingShip, AbstractMap>> _mapStorages;
        /// <summary>
        /// Возвращение списка названий карт
        /// </summary>
        public List<string> Keys => _mapStorages.Keys.ToList();
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private readonly int _pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private readonly int _pictureHeight;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="pictureWidth"></param>
        /// <param name="pictureHeight"></param>
        public MapsCollection(int pictureWidth, int pictureHeight)
        {
            _mapStorages = new Dictionary<string, MapWithSetShipsGeneric<DrowingShip, AbstractMap>>();
            _pictureWidth = pictureWidth;
            _pictureHeight = pictureHeight;
        }
        /// <summary>
        /// Добавление карты
        /// </summary>
        /// <param name="name">Название карты</param>
        /// <param name="map">Карта</param>
        public void AddMap(string name, AbstractMap map)
        {
            if (_mapStorages.ContainsKey(name))
            {
                return;
            }
            _mapStorages.Add(name, new MapWithSetShipsGeneric<DrowingShip, AbstractMap> (_pictureWidth, _pictureHeight, map));
        }
        /// <summary>
        /// Удаление карты
        /// </summary>
        /// <param name="name">Название карты</param>
        public void DelMap(string name)
        {
            if (_mapStorages.ContainsKey(name))
            {
                _mapStorages.Remove(name);
            }
        }
        /// <summary>
        /// Доступ к парковке
        /// </summary>
        /// <param name="ind"></param>
        /// <returns></returns>
        public MapWithSetShipsGeneric<DrowingShip, AbstractMap> this[string ind]
        {
            get
            {
                if (_mapStorages.ContainsKey(ind))
                {
                    return _mapStorages[ind];
                }
                return null;
            }
        }
    }
}
