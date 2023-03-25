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
    public partial class FormMapWithSetShips : Form
    {
        /// <summary>
        /// Объект от класса карты с набором объектов
        /// </summary>
        private MapWithSetShipsGeneric<DrowingShip, AbstractMap> _mapShipsCollectionGeneric;
        /// <summary>
        /// Конструктор
        /// </summary>
        public FormMapWithSetShips()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Добавление объекта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddShip_Click(object sender, EventArgs e)
        {
            if (_mapShipsCollectionGeneric == null)
            {
                return;
            }
            FormShip form = new FormShip();
            if (form.ShowDialog() == DialogResult.OK)
            {
                DrowingShip m_shp = new DrowingShip(form.SelectedShip);
                if (_mapShipsCollectionGeneric + m_shp)
                {
                    MessageBox.Show("Объект добавлен");
                    pictureBoxShip.Image = _mapShipsCollectionGeneric.ShowSet();
                }
                else
                {
                    MessageBox.Show("Не удалось добавить объект");
                }
            }
        }
        /// <summary>
        /// Удаление объекта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonRemoveShip_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maskedTextBoxPosition.Text))
            {
                return;
            }
            if (MessageBox.Show("Удалить объект?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            int pos = Convert.ToInt32(maskedTextBoxPosition.Text);

            if (_mapShipsCollectionGeneric - pos)
            {
                MessageBox.Show("Объект удален");
                pictureBoxShip.Image = _mapShipsCollectionGeneric.ShowSet();
            }
            else
            {
                MessageBox.Show("Не удалось удалить объект");
            }
        }
        /// <summary>
        /// Вывод набора
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonShowStorage_Click(object sender, EventArgs e)
        {
            if (_mapShipsCollectionGeneric == null)
            {
                return;
            }
            pictureBoxShip.Image = _mapShipsCollectionGeneric.ShowSet();
        }
        /// <summary>
        /// Вывод карты
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonShowOnMap_Click(object sender, EventArgs e)
        {
            if (_mapShipsCollectionGeneric == null)
            {
                return;
            }
            pictureBoxShip.Image = _mapShipsCollectionGeneric.ShowOnMap();
        }
        private void ComboBoxSelectorMap_SelectedIndexChanged(object sender, EventArgs e)
        {
            AbstractMap map = null;
            switch (comboBoxSelectorMap.Text)
            {
                case "Доки":
                    map = new Docks();
                    break;
            }
            if (map != null)
            {
                _mapShipsCollectionGeneric = new MapWithSetShipsGeneric<DrowingShip, AbstractMap>(pictureBoxShip.Width, pictureBoxShip.Height, map);
            }
            else
            {
                _mapShipsCollectionGeneric = null;
            }
        }
        private void ButtonMove_Click(object sender, EventArgs e)
        {
            if (_mapShipsCollectionGeneric == null)
            {
                return;
            }
            //получаем имя кнопки
            string name = ((Button)sender)?.Name ?? string.Empty;
            Direction dir = Direction.None;
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
            pictureBoxShip.Image = _mapShipsCollectionGeneric.MoveObject(dir);
        }
    }
}
