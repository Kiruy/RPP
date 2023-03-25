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
            this.maskedTextBoxPosition = new System.Windows.Forms.MaskedTextBox();
            this.ButtonShowOnMap = new System.Windows.Forms.Button();
            this.ButtonShowStorage = new System.Windows.Forms.Button();
            this.ButtonRemoveShip = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.ButtonAddShip = new System.Windows.Forms.Button();
            this.comboBoxSelectorMap = new System.Windows.Forms.ComboBox();
            this.pictureBoxShip = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskedTextBoxPosition);
            this.groupBox1.Controls.Add(this.ButtonShowOnMap);
            this.groupBox1.Controls.Add(this.ButtonShowStorage);
            this.groupBox1.Controls.Add(this.ButtonRemoveShip);
            this.groupBox1.Controls.Add(this.buttonDown);
            this.groupBox1.Controls.Add(this.buttonRight);
            this.groupBox1.Controls.Add(this.buttonUp);
            this.groupBox1.Controls.Add(this.buttonLeft);
            this.groupBox1.Controls.Add(this.ButtonAddShip);
            this.groupBox1.Controls.Add(this.comboBoxSelectorMap);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(583, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // maskedTextBoxPosition
            // 
            this.maskedTextBoxPosition.Location = new System.Drawing.Point(19, 126);
            this.maskedTextBoxPosition.Mask = "00";
            this.maskedTextBoxPosition.Name = "maskedTextBoxPosition";
            this.maskedTextBoxPosition.Size = new System.Drawing.Size(178, 20);
            this.maskedTextBoxPosition.TabIndex = 14;
            // 
            // ButtonShowOnMap
            // 
            this.ButtonShowOnMap.Location = new System.Drawing.Point(19, 314);
            this.ButtonShowOnMap.Name = "ButtonShowOnMap";
            this.ButtonShowOnMap.Size = new System.Drawing.Size(178, 30);
            this.ButtonShowOnMap.TabIndex = 13;
            this.ButtonShowOnMap.Text = "Посмотреть карту";
            this.ButtonShowOnMap.UseVisualStyleBackColor = true;
            this.ButtonShowOnMap.Click += new System.EventHandler(this.ButtonShowOnMap_Click);
            // 
            // ButtonShowStorage
            // 
            this.ButtonShowStorage.Location = new System.Drawing.Point(19, 227);
            this.ButtonShowStorage.Name = "ButtonShowStorage";
            this.ButtonShowStorage.Size = new System.Drawing.Size(178, 30);
            this.ButtonShowStorage.TabIndex = 12;
            this.ButtonShowStorage.Text = "Посмотреть доки";
            this.ButtonShowStorage.UseVisualStyleBackColor = true;
            this.ButtonShowStorage.Click += new System.EventHandler(this.ButtonShowStorage_Click);
            // 
            // ButtonRemoveShip
            // 
            this.ButtonRemoveShip.Location = new System.Drawing.Point(19, 152);
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
            this.buttonDown.BackgroundImage = global::Ship2.Properties.Resources.down;
            this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDown.Location = new System.Drawing.Point(99, 408);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(30, 30);
            this.buttonDown.TabIndex = 10;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.ButtonMove_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRight.BackgroundImage = global::Ship2.Properties.Resources.rightarrows_878801;
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRight.Location = new System.Drawing.Point(135, 408);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(30, 30);
            this.buttonRight.TabIndex = 9;
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.ButtonMove_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUp.BackgroundImage = global::Ship2.Properties.Resources.right;
            this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUp.Location = new System.Drawing.Point(99, 372);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(30, 30);
            this.buttonUp.TabIndex = 8;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.ButtonMove_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLeft.BackgroundImage = global::Ship2.Properties.Resources.left;
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLeft.Location = new System.Drawing.Point(63, 408);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(30, 30);
            this.buttonLeft.TabIndex = 7;
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.ButtonMove_Click);
            // 
            // ButtonAddShip
            // 
            this.ButtonAddShip.Location = new System.Drawing.Point(19, 75);
            this.ButtonAddShip.Name = "ButtonAddShip";
            this.ButtonAddShip.Size = new System.Drawing.Size(178, 30);
            this.ButtonAddShip.TabIndex = 10;
            this.ButtonAddShip.Text = "Добавить корабль";
            this.ButtonAddShip.UseVisualStyleBackColor = true;
            this.ButtonAddShip.Click += new System.EventHandler(this.ButtonAddShip_Click);
            // 
            // comboBoxSelectorMap
            // 
            this.comboBoxSelectorMap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectorMap.FormattingEnabled = true;
            this.comboBoxSelectorMap.Items.AddRange(new object[] {
            "Доки"});
            this.comboBoxSelectorMap.Location = new System.Drawing.Point(19, 30);
            this.comboBoxSelectorMap.Name = "comboBoxSelectorMap";
            this.comboBoxSelectorMap.Size = new System.Drawing.Size(178, 21);
            this.comboBoxSelectorMap.TabIndex = 9;
            this.comboBoxSelectorMap.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSelectorMap_SelectedIndexChanged);
            // 
            // pictureBoxShip
            // 
            this.pictureBoxShip.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBoxShip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxShip.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxShip.Name = "pictureBoxShip";
            this.pictureBoxShip.Size = new System.Drawing.Size(583, 450);
            this.pictureBoxShip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxShip.TabIndex = 6;
            this.pictureBoxShip.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(583, 450);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FormMapWithSetShips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxShip);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMapWithSetShips";
            this.Text = "FormMapWithSetPlanes";
            this.Click += new System.EventHandler(this.ButtonMove_Click);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
    }
}