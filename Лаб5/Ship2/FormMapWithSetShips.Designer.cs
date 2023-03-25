namespace Ship2
{
    partial class FormMapWithSetShips
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxMaps = new System.Windows.Forms.GroupBox();
            this.buttonDeleteMap = new System.Windows.Forms.Button();
            this.buttonAddMap = new System.Windows.Forms.Button();
            this.listBoxMaps = new System.Windows.Forms.ListBox();
            this.textBoxNewMapName = new System.Windows.Forms.TextBox();
            this.comboBoxSelectorMap = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxPosition = new System.Windows.Forms.MaskedTextBox();
            this.ButtonShowOnMap = new System.Windows.Forms.Button();
            this.ButtonShowStorage = new System.Windows.Forms.Button();
            this.ButtonRemoveShip = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.ButtonAddShip = new System.Windows.Forms.Button();
            this.pictureBoxShip = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBoxMaps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBoxMaps);
            this.groupBox1.Controls.Add(this.maskedTextBoxPosition);
            this.groupBox1.Controls.Add(this.ButtonShowOnMap);
            this.groupBox1.Controls.Add(this.ButtonShowStorage);
            this.groupBox1.Controls.Add(this.ButtonRemoveShip);
            this.groupBox1.Controls.Add(this.buttonDown);
            this.groupBox1.Controls.Add(this.buttonRight);
            this.groupBox1.Controls.Add(this.buttonUp);
            this.groupBox1.Controls.Add(this.buttonLeft);
            this.groupBox1.Controls.Add(this.ButtonAddShip);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(567, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 561);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Инструменты";
            // 
            // groupBoxMaps
            // 
            this.groupBoxMaps.Controls.Add(this.buttonDeleteMap);
            this.groupBoxMaps.Controls.Add(this.buttonAddMap);
            this.groupBoxMaps.Controls.Add(this.listBoxMaps);
            this.groupBoxMaps.Controls.Add(this.textBoxNewMapName);
            this.groupBoxMaps.Controls.Add(this.comboBoxSelectorMap);
            this.groupBoxMaps.Location = new System.Drawing.Point(6, 19);
            this.groupBoxMaps.Name = "groupBoxMaps";
            this.groupBoxMaps.Size = new System.Drawing.Size(200, 212);
            this.groupBoxMaps.TabIndex = 15;
            this.groupBoxMaps.TabStop = false;
            this.groupBoxMaps.Text = "Карты";
            // 
            // buttonDeleteMap
            // 
            this.buttonDeleteMap.Location = new System.Drawing.Point(13, 183);
            this.buttonDeleteMap.Name = "buttonDeleteMap";
            this.buttonDeleteMap.Size = new System.Drawing.Size(178, 23);
            this.buttonDeleteMap.TabIndex = 3;
            this.buttonDeleteMap.Text = "Удалить карту";
            this.buttonDeleteMap.UseVisualStyleBackColor = true;
            this.buttonDeleteMap.Click += new System.EventHandler(this.ButtonDeleteMap_Click);
            // 
            // buttonAddMap
            // 
            this.buttonAddMap.Location = new System.Drawing.Point(13, 92);
            this.buttonAddMap.Name = "buttonAddMap";
            this.buttonAddMap.Size = new System.Drawing.Size(178, 23);
            this.buttonAddMap.TabIndex = 2;
            this.buttonAddMap.Text = "Добавить карту";
            this.buttonAddMap.UseVisualStyleBackColor = true;
            this.buttonAddMap.Click += new System.EventHandler(this.ButtonAddMap_Click);
            // 
            // listBoxMaps
            // 
            this.listBoxMaps.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listBoxMaps.FormattingEnabled = true;
            this.listBoxMaps.Location = new System.Drawing.Point(13, 121);
            this.listBoxMaps.Name = "listBoxMaps";
            this.listBoxMaps.Size = new System.Drawing.Size(178, 56);
            this.listBoxMaps.TabIndex = 1;
            this.listBoxMaps.SelectedIndexChanged += new System.EventHandler(this.ListBoxMaps_SelectedIndexChanged);
            // 
            // textBoxNewMapName
            // 
            this.textBoxNewMapName.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBoxNewMapName.Location = new System.Drawing.Point(13, 20);
            this.textBoxNewMapName.Name = "textBoxNewMapName";
            this.textBoxNewMapName.Size = new System.Drawing.Size(178, 20);
            this.textBoxNewMapName.TabIndex = 0;
            // 
            // comboBoxSelectorMap
            // 
            this.comboBoxSelectorMap.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxSelectorMap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectorMap.FormattingEnabled = true;
            this.comboBoxSelectorMap.Items.AddRange(new object[] {
            "Доки",
            "Доки 2"});
            this.comboBoxSelectorMap.Location = new System.Drawing.Point(13, 46);
            this.comboBoxSelectorMap.Name = "comboBoxSelectorMap";
            this.comboBoxSelectorMap.Size = new System.Drawing.Size(178, 21);
            this.comboBoxSelectorMap.TabIndex = 9;
            // 
            // maskedTextBoxPosition
            // 
            this.maskedTextBoxPosition.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.maskedTextBoxPosition.Location = new System.Drawing.Point(19, 291);
            this.maskedTextBoxPosition.Mask = "00";
            this.maskedTextBoxPosition.Name = "maskedTextBoxPosition";
            this.maskedTextBoxPosition.Size = new System.Drawing.Size(178, 20);
            this.maskedTextBoxPosition.TabIndex = 14;
            // 
            // ButtonShowOnMap
            // 
            this.ButtonShowOnMap.Location = new System.Drawing.Point(19, 405);
            this.ButtonShowOnMap.Name = "ButtonShowOnMap";
            this.ButtonShowOnMap.Size = new System.Drawing.Size(178, 30);
            this.ButtonShowOnMap.TabIndex = 13;
            this.ButtonShowOnMap.Text = "Посмотреть карту";
            this.ButtonShowOnMap.UseVisualStyleBackColor = true;
            this.ButtonShowOnMap.Click += new System.EventHandler(this.ButtonShowOnMap_Click);
            // 
            // ButtonShowStorage
            // 
            this.ButtonShowStorage.Location = new System.Drawing.Point(19, 369);
            this.ButtonShowStorage.Name = "ButtonShowStorage";
            this.ButtonShowStorage.Size = new System.Drawing.Size(178, 30);
            this.ButtonShowStorage.TabIndex = 12;
            this.ButtonShowStorage.Text = "Посмотреть доки";
            this.ButtonShowStorage.UseVisualStyleBackColor = true;
            this.ButtonShowStorage.Click += new System.EventHandler(this.ButtonShowStorage_Click);
            // 
            // ButtonRemoveShip
            // 
            this.ButtonRemoveShip.Location = new System.Drawing.Point(19, 317);
            this.ButtonRemoveShip.Name = "ButtonRemoveShip";
            this.ButtonRemoveShip.Size = new System.Drawing.Size(178, 30);
            this.ButtonRemoveShip.TabIndex = 11;
            this.ButtonRemoveShip.Text = "Удалить корабль";
            this.ButtonRemoveShip.UseVisualStyleBackColor = true;
            this.ButtonRemoveShip.Click += new System.EventHandler(this.ButtonRemoveShip_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDown.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonDown.BackgroundImage = global::Ship2.Properties.Resources.down;
            this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDown.Location = new System.Drawing.Point(96, 502);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(30, 30);
            this.buttonDown.TabIndex = 10;
            this.buttonDown.UseVisualStyleBackColor = false;
            this.buttonDown.Click += new System.EventHandler(this.ButtonMove_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRight.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonRight.BackgroundImage = global::Ship2.Properties.Resources.rightarrows_878801;
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRight.Location = new System.Drawing.Point(132, 502);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(30, 30);
            this.buttonRight.TabIndex = 9;
            this.buttonRight.UseVisualStyleBackColor = false;
            this.buttonRight.Click += new System.EventHandler(this.ButtonMove_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonUp.BackgroundImage = global::Ship2.Properties.Resources.right;
            this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUp.Location = new System.Drawing.Point(96, 466);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(30, 30);
            this.buttonUp.TabIndex = 8;
            this.buttonUp.UseVisualStyleBackColor = false;
            this.buttonUp.Click += new System.EventHandler(this.ButtonMove_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLeft.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonLeft.BackgroundImage = global::Ship2.Properties.Resources.left;
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLeft.Location = new System.Drawing.Point(60, 502);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(30, 30);
            this.buttonLeft.TabIndex = 7;
            this.buttonLeft.UseVisualStyleBackColor = false;
            this.buttonLeft.Click += new System.EventHandler(this.ButtonMove_Click);
            // 
            // ButtonAddShip
            // 
            this.ButtonAddShip.Location = new System.Drawing.Point(19, 255);
            this.ButtonAddShip.Name = "ButtonAddShip";
            this.ButtonAddShip.Size = new System.Drawing.Size(178, 30);
            this.ButtonAddShip.TabIndex = 10;
            this.ButtonAddShip.Text = "Добавить корабль";
            this.ButtonAddShip.UseVisualStyleBackColor = true;
            this.ButtonAddShip.Click += new System.EventHandler(this.ButtonAddShip_Click);
            // 
            // pictureBoxShip
            // 
            this.pictureBoxShip.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBoxShip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxShip.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxShip.Name = "pictureBoxShip";
            this.pictureBoxShip.Size = new System.Drawing.Size(567, 561);
            this.pictureBoxShip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxShip.TabIndex = 6;
            this.pictureBoxShip.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(567, 561);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FormMapWithSetShips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pictureBoxShip);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMapWithSetShips";
            this.Text = "FormMapWithSetPlanes";
            this.Click += new System.EventHandler(this.ButtonMove_Click);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxMaps.ResumeLayout(false);
            this.groupBoxMaps.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ButtonAddShip;
        private System.Windows.Forms.ComboBox comboBoxSelectorMap;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPosition;
        private System.Windows.Forms.Button ButtonShowOnMap;
        private System.Windows.Forms.Button ButtonShowStorage;
        private System.Windows.Forms.Button ButtonRemoveShip;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.PictureBox pictureBoxShip;
        private System.Windows.Forms.GroupBox groupBoxMaps;
        private System.Windows.Forms.Button buttonDeleteMap;
        private System.Windows.Forms.Button buttonAddMap;
        private System.Windows.Forms.ListBox listBoxMaps;
        private System.Windows.Forms.TextBox textBoxNewMapName;
    }
}