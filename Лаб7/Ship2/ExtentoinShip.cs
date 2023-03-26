using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ship2
{
    internal static class ExtentoinShip
    {
        /// <summary>
        /// Разделитель для записи информации по объекту в файл
        /// </summary>
        private static readonly char _separatorForObject = ':';
        /// <summary>
        /// Создание объекта из строки
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static DrowingClassicShip CreateDrawningShip(this string info)
        {
            string[] strs = info.Split(_separatorForObject);
            if (strs.Length == 3)
            {
                return new DrowingClassicShip(Convert.ToInt32(strs[0]),
                Convert.ToInt32(strs[1]), Color.FromName(strs[2]));
            }
            if (strs.Length == 6)
            {
                return new DrowingBattleShip(Convert.ToInt32(strs[0]),
                Convert.ToInt32(strs[1]), Color.FromName(strs[2]),
               Color.FromName(strs[3]), Convert.ToBoolean(strs[4]),
               Convert.ToBoolean(strs[5]));
            }
            return null;
        }
        /// <summary>
        /// Получение данных для сохранения в файл
        /// </summary>
        /// <param name="drowningShip"></param>
        /// <returns></returns>
        public static string GetDataForSave(this DrowingClassicShip drowningShip)
        {
            var ship = drowningShip.Ship;
            var str = $"{ship.MaxSpeed}{_separatorForObject}{ship.Weight}{_separatorForObject}{ship.MainColor.Name}";
            if (ship is BattleShip battleShip)
            {
                return $"{str}{_separatorForObject}{battleShip.DopColor.Name}{_separatorForObject}{battleShip.Rocket}{_separatorForObject}{battleShip.ShipTower}";
            }
            return str;

        }
    }
}
