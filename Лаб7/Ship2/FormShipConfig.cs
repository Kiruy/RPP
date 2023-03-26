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
    public partial class FormShipConfig : Form
    {
        /// <summary>
        /// Переменная-выбранная машина
        /// </summary>
        DrowingClassicShip _ship = null;
        /// <summary>
        /// Событие
        /// </summary>
        private event ShipDelegate EventAddShip;
        /// <summary>
        /// Конструктор
        /// </summary>
        Color main_color__ = Color.Gray;
        Color dop_color__ = Color.Black;
        public FormShipConfig()
        {
            InitializeComponent();
            panelBlack.MouseDown += PanelColor_MouseDown;
            panelLime.MouseDown += PanelColor_MouseDown;
            panelGrey.MouseDown += PanelColor_MouseDown;
            panelIndigo.MouseDown += PanelColor_MouseDown;
            panelRed.MouseDown += PanelColor_MouseDown;
            panelOrange.MouseDown += PanelColor_MouseDown;
            panelYellow.MouseDown += PanelColor_MouseDown;
            panelBlue.MouseDown += PanelColor_MouseDown;

        }
        /// <summary>
        /// Отрисовать машину
        /// </summary>
        private void DrawShip()
        {
            Bitmap bmp = new Bitmap(pictureBoxPlane.Width, pictureBoxPlane.Height);
            Graphics gr = Graphics.FromImage(bmp);
            _ship?.SetPosition(5, 5, pictureBoxPlane.Width,
           pictureBoxPlane.Height);
            _ship?.DrawShip(gr);
            pictureBoxPlane.Image = bmp;
        }
        /// <summary>
        /// Добавление события
        /// </summary>
        /// <param name="ev"></param>
        public void AddEvent(ShipDelegate ev)
        {
            if (EventAddShip == null)
            {
                EventAddShip = new ShipDelegate(ev);
            }
            else
            {
                EventAddShip += ev;
            }
        }
        /// <summary>
        /// Передаем информацию при нажатии на Label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelPlane_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Label).DoDragDrop((sender as Label).Name, DragDropEffects.Move | DragDropEffects.Copy);

        }
        /// <summary>
        /// Проверка получаемой информации (ее типа на соответствие требуемому)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PanelPlane_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }

        }
        /// <summary>
        /// Действия при приеме перетаскиваемой информации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PanelPlane_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "labelMilitaryPlane":
                    _ship = new DrowingClassicShip((int)numericUpDownMaxSpeed.Value,
                   (int)numericUpDownWeight.Value, Color.Gray);
                    break;
                case "labelMilitaryAirFighterPlane":
                    _ship = new DrowingBattleShip((int)numericUpDownMaxSpeed.Value,
                   (int)numericUpDownWeight.Value, Color.Gray, Color.Black,
                    checkBoxRockets.Checked, checkBoxShipTower.Checked);
                    dop_color__ = Color.Black;
                    break;
            }
            DrawShip();
        }
        /// <summary>
        /// Отправляем цвет с панели
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PanelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor, DragDropEffects.Move | DragDropEffects.Copy);

        }
        /// <summary>
        /// Проверка получаемой информации (ее типа на соответствие требуемому)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        /// <summary>
        /// Принимаем основной цвет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            main_color__ = (Color)e.Data.GetData(typeof(Color));
            if (_ship is DrowingBattleShip)
            {
                DrowingBattleShip BattleShip = new DrowingBattleShip((int)numericUpDownMaxSpeed.Value,
                    (int)numericUpDownWeight.Value, main_color__, dop_color__,
                     checkBoxRockets.Checked, checkBoxShipTower.Checked);
                _ship = BattleShip;
                DrawShip();
            }
            else
            {
                DrowingClassicShip ship = new DrowingClassicShip((int)numericUpDownMaxSpeed.Value,
                       (int)numericUpDownWeight.Value, main_color__);
                _ship = ship;
                main_color__ = Color.Gray;
                DrawShip();
            }

        }
        /// <summary>
        /// Принимаем дополнительный цвет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            dop_color__ = (Color)e.Data.GetData(typeof(Color));
            if (_ship is DrowingBattleShip)
            {
                DrowingBattleShip BattleShip = new DrowingBattleShip((int)numericUpDownMaxSpeed.Value,
                   (int)numericUpDownWeight.Value, main_color__, dop_color__,
                    checkBoxRockets.Checked, checkBoxShipTower.Checked);
                _ship = BattleShip;
                DrawShip();
            }
        }
        /// <summary>
        /// Добавление машины
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonOk_Click(object sender, EventArgs e)
        {
            EventAddShip?.Invoke(_ship);
            Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

