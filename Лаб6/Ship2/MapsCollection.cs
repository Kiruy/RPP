using System;
using System.Collections.Generic;
using System.IO;
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
        private readonly char separatorDict = '|';
        private readonly char separatorData = ';';
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
        /// <summary>
        /// Метод записи информации в файл
        /// </summary>
        /// <param name="text">Строка, которую следует записать</param>
        /// <param name="stream">Поток для записи</param>
        private static void WriteToFile(string text, FileStream stream)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(text);
            stream.Write(info, 0, info.Length);
        }
        /// <summary>
        /// Сохранение информации по автомобилям в хранилище в файл
        /// </summary>
        /// <param name="filename">Путь и имя файла</param>
        /// <returns></returns>
        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                WriteToFile($"MapsCollection{Environment.NewLine}", fs);
                foreach (var storage in _mapStorages)
                {

                    WriteToFile($"{storage.Key}{separatorDict}{storage.Value.GetData(separatorDict, separatorData)}{Environment.NewLine}", fs);
                }
            }
            return true;
        }
        /// <summary>
        /// Загрузка нформации по автомобилям на парковках из файла
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }
            string bufferTextFromFile = "";
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                byte[] b = new byte[fs.Length];
                UTF8Encoding temp = new UTF8Encoding(true);
                while (fs.Read(b, 0, b.Length) > 0)
                {
                    bufferTextFromFile += temp.GetString(b);
                }
            }
            var strs = bufferTextFromFile.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            if (!strs[0].Contains("MapsCollection"))
            {
                //если нет такой записи, то это не те данные
                return false;
            }
            //очищаем записи
            _mapStorages.Clear();
            for (int i = 1; i < strs.Length; ++i)
            {
                var elem = strs[i].Split(separatorDict);
                AbstractMap map = null;
                switch (elem[1])
                {
                    case "Ангар":
                        map = new Docks();
                        break;
                    case "Ангар2":
                        map = new Docks_2();
                        break;
                }
                _mapStorages.Add(elem[0], new MapWithSetShipsGeneric<DrowingShip, AbstractMap>(_pictureWidth, _pictureHeight,map));
                _mapStorages[elem[0]].LoadData(elem[2].Split(separatorData, (char)StringSplitOptions.RemoveEmptyEntries));
            }
            return true;
        }
    }
}
