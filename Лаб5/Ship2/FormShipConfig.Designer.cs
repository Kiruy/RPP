namespace Ship2
{
    partial class FormShipConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelMilitaryAirFighterPlane = new System.Windows.Forms.Label();
            this.labelMilitaryPlane = new System.Windows.Forms.Label();
            this.panelPlane = new System.Windows.Forms.Panel();
            this.pictureBoxPlane = new System.Windows.Forms.PictureBox();
            this.labelMainColor = new System.Windows.Forms.Label();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.groupBoxParameter = new System.Windows.Forms.GroupBox();
            this.checkBoxShipTower = new System.Windows.Forms.CheckBox();
            this.checkBoxRockets = new System.Windows.Forms.CheckBox();
            this.groupColors = new System.Windows.Forms.GroupBox();
            this.panelOrange = new System.Windows.Forms.Panel();
            this.panelIndigo = new System.Windows.Forms.Panel();
            this.panelGrey = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelLime = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxSpeed = new System.Windows.Forms.NumericUpDown();
            this.labelWeightPlane = new System.Windows.Forms.Label();
            this.labelMaxSpeed = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panelPlane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlane)).BeginInit();
            this.groupBoxParameter.SuspendLayout();
            this.groupColors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMilitaryAirFighterPlane
            // 
            this.labelMilitaryAirFighterPlane.BackColor = System.Drawing.Color.Cornsilk;
            this.labelMilitaryAirFighterPlane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMilitaryAirFighterPlane.Location = new System.Drawing.Point(353, 160);
            this.labelMilitaryAirFighterPlane.Name = "labelMilitaryAirFighterPlane";
            this.labelMilitaryAirFighterPlane.Size = new System.Drawing.Size(100, 40);
            this.labelMilitaryAirFighterPlane.TabIndex = 1;
            this.labelMilitaryAirFighterPlane.Text = "Военный корабль";
            this.labelMilitaryAirFighterPlane.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMilitaryAirFighterPlane.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelPlane_MouseDown);
            // 
            // labelMilitaryPlane
            // 
            this.labelMilitaryPlane.BackColor = System.Drawing.Color.Cornsilk;
            this.labelMilitaryPlane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMilitaryPlane.Location = new System.Drawing.Point(216, 160);
            this.labelMilitaryPlane.Name = "labelMilitaryPlane";
            this.labelMilitaryPlane.Size = new System.Drawing.Size(100, 40);
            this.labelMilitaryPlane.TabIndex = 0;
            this.labelMilitaryPlane.Text = "Классический корабль";
            this.labelMilitaryPlane.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMilitaryPlane.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelPlane_MouseDown);
            // 
            // panelPlane
            // 
            this.panelPlane.AllowDrop = true;
            this.panelPlane.BackColor = System.Drawing.Color.AliceBlue;
            this.panelPlane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPlane.Controls.Add(this.pictureBoxPlane);
            this.panelPlane.Controls.Add(this.labelMainColor);
            this.panelPlane.Controls.Add(this.labelDopColor);
            this.panelPlane.Location = new System.Drawing.Point(493, 29);
            this.panelPlane.Name = "panelPlane";
            this.panelPlane.Size = new System.Drawing.Size(244, 181);
            this.panelPlane.TabIndex = 1;
            this.panelPlane.DragDrop += new System.Windows.Forms.DragEventHandler(this.PanelPlane_DragDrop);
            this.panelPlane.DragEnter += new System.Windows.Forms.DragEventHandler(this.PanelPlane_DragEnter);
            // 
            // pictureBoxPlane
            // 
            this.pictureBoxPlane.BackColor = System.Drawing.Color.AliceBlue;
            this.pictureBoxPlane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPlane.Location = new System.Drawing.Point(16, 42);
            this.pictureBoxPlane.Name = "pictureBoxPlane";
            this.pictureBoxPlane.Size = new System.Drawing.Size(214, 114);
            this.pictureBoxPlane.TabIndex = 0;
            this.pictureBoxPlane.TabStop = false;
            // 
            // labelMainColor
            // 
            this.labelMainColor.AllowDrop = true;
            this.labelMainColor.BackColor = System.Drawing.Color.Cornsilk;
            this.labelMainColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMainColor.Location = new System.Drawing.Point(16, 4);
            this.labelMainColor.Name = "labelMainColor";
            this.labelMainColor.Size = new System.Drawing.Size(100, 35);
            this.labelMainColor.TabIndex = 0;
            this.labelMainColor.Text = "Основной цвет";
            this.labelMainColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMainColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.LabelBaseColor_DragDrop);
            this.labelMainColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.LabelBaseColor_DragEnter);
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BackColor = System.Drawing.Color.Cornsilk;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(130, 4);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(100, 35);
            this.labelDopColor.TabIndex = 1;
            this.labelDopColor.Text = "Дополнительный цвет";
            this.labelDopColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.LabelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.LabelBaseColor_DragEnter);
            // 
            // groupBoxParameter
            // 
            this.groupBoxParameter.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBoxParameter.Controls.Add(this.labelMilitaryAirFighterPlane);
            this.groupBoxParameter.Controls.Add(this.checkBoxShipTower);
            this.groupBoxParameter.Controls.Add(this.labelMilitaryPlane);
            this.groupBoxParameter.Controls.Add(this.checkBoxRockets);
            this.groupBoxParameter.Controls.Add(this.groupColors);
            this.groupBoxParameter.Controls.Add(this.numericUpDownWeight);
            this.groupBoxParameter.Controls.Add(this.numericUpDownMaxSpeed);
            this.groupBoxParameter.Controls.Add(this.labelWeightPlane);
            this.groupBoxParameter.Controls.Add(this.labelMaxSpeed);
            this.groupBoxParameter.Location = new System.Drawing.Point(21, 29);
            this.groupBoxParameter.Name = "groupBoxParameter";
            this.groupBoxParameter.Size = new System.Drawing.Size(466, 220);
            this.groupBoxParameter.TabIndex = 2;
            this.groupBoxParameter.TabStop = false;
            this.groupBoxParameter.Text = "Параметры";
            // 
            // checkBoxShipTower
            // 
            this.checkBoxShipTower.AutoSize = true;
            this.checkBoxShipTower.Location = new System.Drawing.Point(6, 128);
            this.checkBoxShipTower.Name = "checkBoxShipTower";
            this.checkBoxShipTower.Size = new System.Drawing.Size(165, 17);
            this.checkBoxShipTower.TabIndex = 5;
            this.checkBoxShipTower.Text = "Наличие башни с орудиями\r\n";
            this.checkBoxShipTower.UseVisualStyleBackColor = true;
            // 
            // checkBoxRockets
            // 
            this.checkBoxRockets.AutoSize = true;
            this.checkBoxRockets.Location = new System.Drawing.Point(6, 105);
            this.checkBoxRockets.Name = "checkBoxRockets";
            this.checkBoxRockets.Size = new System.Drawing.Size(160, 17);
            this.checkBoxRockets.TabIndex = 4;
            this.checkBoxRockets.Text = "Наличие отсека для ракет";
            this.checkBoxRockets.UseVisualStyleBackColor = true;
            // 
            // groupColors
            // 
            this.groupColors.BackColor = System.Drawing.Color.LightCyan;
            this.groupColors.Controls.Add(this.panelOrange);
            this.groupColors.Controls.Add(this.panelIndigo);
            this.groupColors.Controls.Add(this.panelGrey);
            this.groupColors.Controls.Add(this.panelBlue);
            this.groupColors.Controls.Add(this.panelBlack);
            this.groupColors.Controls.Add(this.panelYellow);
            this.groupColors.Controls.Add(this.panelLime);
            this.groupColors.Controls.Add(this.panelRed);
            this.groupColors.Location = new System.Drawing.Point(216, 24);
            this.groupColors.Name = "groupColors";
            this.groupColors.Size = new System.Drawing.Size(237, 121);
            this.groupColors.TabIndex = 3;
            this.groupColors.TabStop = false;
            this.groupColors.Text = "Цвета";
            // 
            // panelOrange
            // 
            this.panelOrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelOrange.Location = new System.Drawing.Point(186, 65);
            this.panelOrange.Name = "panelOrange";
            this.panelOrange.Size = new System.Drawing.Size(40, 40);
            this.panelOrange.TabIndex = 9;
            this.panelOrange.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelColor_MouseDown);
            // 
            // panelIndigo
            // 
            this.panelIndigo.BackColor = System.Drawing.Color.Indigo;
            this.panelIndigo.Location = new System.Drawing.Point(128, 65);
            this.panelIndigo.Name = "panelIndigo";
            this.panelIndigo.Size = new System.Drawing.Size(40, 40);
            this.panelIndigo.TabIndex = 8;
            this.panelIndigo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelColor_MouseDown);
            // 
            // panelGrey
            // 
            this.panelGrey.BackColor = System.Drawing.Color.Silver;
            this.panelGrey.Location = new System.Drawing.Point(186, 19);
            this.panelGrey.Name = "panelGrey";
            this.panelGrey.Size = new System.Drawing.Size(40, 40);
            this.panelGrey.TabIndex = 7;
            this.panelGrey.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelColor_MouseDown);
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.Location = new System.Drawing.Point(128, 19);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(40, 40);
            this.panelBlue.TabIndex = 6;
            this.panelBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelColor_MouseDown);
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.Location = new System.Drawing.Point(72, 65);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(40, 40);
            this.panelBlack.TabIndex = 5;
            this.panelBlack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelColor_MouseDown);
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.Location = new System.Drawing.Point(16, 65);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(40, 40);
            this.panelYellow.TabIndex = 4;
            this.panelYellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelColor_MouseDown);
            // 
            // panelLime
            // 
            this.panelLime.BackColor = System.Drawing.Color.Lime;
            this.panelLime.Location = new System.Drawing.Point(72, 19);
            this.panelLime.Name = "panelLime";
            this.panelLime.Size = new System.Drawing.Size(40, 40);
            this.panelLime.TabIndex = 3;
            this.panelLime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelColor_MouseDown);
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.Location = new System.Drawing.Point(16, 19);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(40, 40);
            this.panelRed.TabIndex = 2;
            this.panelRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelColor_MouseDown);
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.Location = new System.Drawing.Point(18, 79);
            this.numericUpDownWeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownWeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownWeight.Name = "numericUpDownWeight";
            this.numericUpDownWeight.Size = new System.Drawing.Size(54, 20);
            this.numericUpDownWeight.TabIndex = 3;
            this.numericUpDownWeight.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // numericUpDownMaxSpeed
            // 
            this.numericUpDownMaxSpeed.Location = new System.Drawing.Point(18, 40);
            this.numericUpDownMaxSpeed.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownMaxSpeed.Name = "numericUpDownMaxSpeed";
            this.numericUpDownMaxSpeed.Size = new System.Drawing.Size(55, 20);
            this.numericUpDownMaxSpeed.TabIndex = 2;
            this.numericUpDownMaxSpeed.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // labelWeightPlane
            // 
            this.labelWeightPlane.AutoSize = true;
            this.labelWeightPlane.Location = new System.Drawing.Point(11, 63);
            this.labelWeightPlane.Name = "labelWeightPlane";
            this.labelWeightPlane.Size = new System.Drawing.Size(78, 13);
            this.labelWeightPlane.TabIndex = 1;
            this.labelWeightPlane.Text = "Вес самолета";
            // 
            // labelMaxSpeed
            // 
            this.labelMaxSpeed.AutoSize = true;
            this.labelMaxSpeed.Location = new System.Drawing.Point(11, 24);
            this.labelMaxSpeed.Name = "labelMaxSpeed";
            this.labelMaxSpeed.Size = new System.Drawing.Size(87, 13);
            this.labelMaxSpeed.TabIndex = 0;
            this.labelMaxSpeed.Text = "Макс. скорость";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Cornsilk;
            this.buttonAdd.Location = new System.Drawing.Point(510, 216);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(101, 39);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Добавить корабль";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Cornsilk;
            this.buttonCancel.Location = new System.Drawing.Point(626, 216);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(98, 39);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отменить создание";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // FormShipConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(747, 304);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBoxParameter);
            this.Controls.Add(this.panelPlane);
            this.Name = "FormShipConfig";
            this.Text = "FormPlaneConfig";
            this.panelPlane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlane)).EndInit();
            this.groupBoxParameter.ResumeLayout(false);
            this.groupBoxParameter.PerformLayout();
            this.groupColors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelMilitaryAirFighterPlane;
        private System.Windows.Forms.Label labelMilitaryPlane;
        private System.Windows.Forms.Panel panelPlane;
        private System.Windows.Forms.PictureBox pictureBoxPlane;
        private System.Windows.Forms.GroupBox groupBoxParameter;
        private System.Windows.Forms.CheckBox checkBoxRockets;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxSpeed;
        private System.Windows.Forms.Label labelWeightPlane;
        private System.Windows.Forms.Label labelMaxSpeed;
        private System.Windows.Forms.CheckBox checkBoxShipTower;
        private System.Windows.Forms.GroupBox groupColors;
        private System.Windows.Forms.Panel panelOrange;
        private System.Windows.Forms.Panel panelIndigo;
        private System.Windows.Forms.Panel panelGrey;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelLime;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Label labelMainColor;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
    }
}