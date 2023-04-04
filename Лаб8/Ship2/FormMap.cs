using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ship2
{
    public partial class FormMap : Form
    {
        private AbstractMap _abstractMap;
        public FormMap()
        {
            InitializeComponent();
            _abstractMap = new SimpleMap();
        }
        /// <summary>
        /// Заполнение информации по объекту
        /// </summary>
        private void SetData(DrowingClassicShip w_Ship)
        {
            toolStripStatusLabelSpeed.Text = $"Скорость: {w_Ship.Ship.MaxSpeed}";
            toolStripStatusLabelWeight.Text = $"Вес: {w_Ship.Ship.Weight}";
            toolStripStatusLabelMainColor.Text = $"Цвет:{ w_Ship.Ship.MainColor.Name}";
            pictureBoxShip.Image = _abstractMap.CreateMap(pictureBoxShip.Width, pictureBoxShip.Height, new DrowingShip(w_Ship));
        }
        /// <summary>
        /// Обработка нажатия кнопки "Создать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            var w_Ship = new DrowingClassicShip(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Purple);
            SetData(w_Ship);
        }
        /// <summary>
        /// Обработка нажатия кнопки "Модификация"
        /// </summary>
        private void ButtonCreateModify_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            var w_Ship = new DrowingBattleShip(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Purple, Color.Yellow, true, true);
            SetData(w_Ship);
        }
        /// <summary>
        /// Обработка нажатия кнопок управления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = ((Button)sender)?.Name ?? string.Empty;
            Direction dir = Direction.None;
            try
            {
                switch (name)
                {
                    case "buttonUp":
                        dir = Direction.Up;
                        break;
                    case "buttonDown":
                        dir = Direction.Down;
                        break;
                    case "buttonLeft":
                        dir = Direction.Left;
                        break;
                    case "buttonRight":
                        dir = Direction.Right;
                        break;
                }
                pictureBoxShip.Image = _abstractMap?.MoveObject(dir);
            }
            catch (Exception)
            {
                MessageBox.Show("Создайте корабль!!!", "Ошибка взаимодействия!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            /// <summary>
            /// Изменение размеров формы
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
        }
        /// <summary>
        /// Смена карты
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBoxSelectorMap_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxSelectorMap.Text)
            {
                case "Простая карта":
                    _abstractMap = new SimpleMap();
                    break;
            }
        }
    }
}
