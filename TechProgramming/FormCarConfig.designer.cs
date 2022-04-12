
namespace TechProgramming
{
    partial class FormCarConfig
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
            this.labelCran = new System.Windows.Forms.Label();
            this.labelCar = new System.Windows.Forms.Label();
            this.ParametersgroupBox = new System.Windows.Forms.GroupBox();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.RotaryPlatformcheckBox = new System.Windows.Forms.CheckBox();
            this.numericUpDownMaxSpeed = new System.Windows.Forms.NumericUpDown();
            this.CounterWeightcheckBox = new System.Windows.Forms.CheckBox();
            this.BucketcheckBox = new System.Windows.Forms.CheckBox();
            this.Heightlabel = new System.Windows.Forms.Label();
            this.MaxSpeedlabel = new System.Windows.Forms.Label();
            this.panelCar = new System.Windows.Forms.Panel();
            this.pictureBoxCar = new System.Windows.Forms.PictureBox();
            this.ColorgroupBox = new System.Windows.Forms.GroupBox();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.labelBaseColor = new System.Windows.Forms.Label();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.panelGray = new System.Windows.Forms.Panel();
            this.panelOrange = new System.Windows.Forms.Panel();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.ParametersgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).BeginInit();
            this.panelCar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).BeginInit();
            this.ColorgroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelCran);
            this.groupBox1.Controls.Add(this.labelCar);
            this.groupBox1.Location = new System.Drawing.Point(2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип кузова";
            // 
            // labelCran
            // 
            this.labelCran.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCran.Location = new System.Drawing.Point(16, 56);
            this.labelCran.Name = "labelCran";
            this.labelCran.Size = new System.Drawing.Size(100, 31);
            this.labelCran.TabIndex = 1;
            this.labelCran.Text = "Модифицированный кран";
            this.labelCran.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCran.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelCran_MouseDown);
            // 
            // labelCar
            // 
            this.labelCar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCar.Location = new System.Drawing.Point(16, 16);
            this.labelCar.Name = "labelCar";
            this.labelCar.Size = new System.Drawing.Size(100, 31);
            this.labelCar.TabIndex = 0;
            this.labelCar.Text = "Обычный кран";
            this.labelCar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelCar_MouseDown);
            // 
            // ParametersgroupBox
            // 
            this.ParametersgroupBox.Controls.Add(this.numericUpDownWeight);
            this.ParametersgroupBox.Controls.Add(this.RotaryPlatformcheckBox);
            this.ParametersgroupBox.Controls.Add(this.numericUpDownMaxSpeed);
            this.ParametersgroupBox.Controls.Add(this.CounterWeightcheckBox);
            this.ParametersgroupBox.Controls.Add(this.BucketcheckBox);
            this.ParametersgroupBox.Controls.Add(this.Heightlabel);
            this.ParametersgroupBox.Controls.Add(this.MaxSpeedlabel);
            this.ParametersgroupBox.Location = new System.Drawing.Point(2, 132);
            this.ParametersgroupBox.Name = "ParametersgroupBox";
            this.ParametersgroupBox.Size = new System.Drawing.Size(361, 117);
            this.ParametersgroupBox.TabIndex = 0;
            this.ParametersgroupBox.TabStop = false;
            this.ParametersgroupBox.Text = "Параметры";
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.Location = new System.Drawing.Point(62, 82);
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
            this.numericUpDownWeight.TabIndex = 5;
            this.numericUpDownWeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // RotaryPlatformcheckBox
            // 
            this.RotaryPlatformcheckBox.AutoSize = true;
            this.RotaryPlatformcheckBox.Location = new System.Drawing.Point(138, 82);
            this.RotaryPlatformcheckBox.Name = "RotaryPlatformcheckBox";
            this.RotaryPlatformcheckBox.Size = new System.Drawing.Size(108, 17);
            this.RotaryPlatformcheckBox.TabIndex = 3;
            this.RotaryPlatformcheckBox.Text = "Вращаю. платф.";
            this.RotaryPlatformcheckBox.UseVisualStyleBackColor = true;
            // 
            // numericUpDownMaxSpeed
            // 
            this.numericUpDownMaxSpeed.Location = new System.Drawing.Point(62, 43);
            this.numericUpDownMaxSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownMaxSpeed.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownMaxSpeed.Name = "numericUpDownMaxSpeed";
            this.numericUpDownMaxSpeed.Size = new System.Drawing.Size(54, 20);
            this.numericUpDownMaxSpeed.TabIndex = 6;
            this.numericUpDownMaxSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // CounterWeightcheckBox
            // 
            this.CounterWeightcheckBox.AutoSize = true;
            this.CounterWeightcheckBox.Location = new System.Drawing.Point(138, 36);
            this.CounterWeightcheckBox.Name = "CounterWeightcheckBox";
            this.CounterWeightcheckBox.Size = new System.Drawing.Size(85, 17);
            this.CounterWeightcheckBox.TabIndex = 2;
            this.CounterWeightcheckBox.Text = "противовес";
            this.CounterWeightcheckBox.UseVisualStyleBackColor = true;
            // 
            // BucketcheckBox
            // 
            this.BucketcheckBox.AutoSize = true;
            this.BucketcheckBox.Location = new System.Drawing.Point(138, 59);
            this.BucketcheckBox.Name = "BucketcheckBox";
            this.BucketcheckBox.Size = new System.Drawing.Size(53, 17);
            this.BucketcheckBox.TabIndex = 4;
            this.BucketcheckBox.Text = "Ковш";
            this.BucketcheckBox.UseVisualStyleBackColor = true;
            // 
            // Heightlabel
            // 
            this.Heightlabel.AutoSize = true;
            this.Heightlabel.Location = new System.Drawing.Point(10, 66);
            this.Heightlabel.Name = "Heightlabel";
            this.Heightlabel.Size = new System.Drawing.Size(54, 13);
            this.Heightlabel.TabIndex = 1;
            this.Heightlabel.Text = "вес авто:";
            // 
            // MaxSpeedlabel
            // 
            this.MaxSpeedlabel.AutoSize = true;
            this.MaxSpeedlabel.Location = new System.Drawing.Point(10, 27);
            this.MaxSpeedlabel.Name = "MaxSpeedlabel";
            this.MaxSpeedlabel.Size = new System.Drawing.Size(90, 13);
            this.MaxSpeedlabel.TabIndex = 0;
            this.MaxSpeedlabel.Text = "Макс. скорость:";
            // 
            // panelCar
            // 
            this.panelCar.AllowDrop = true;
            this.panelCar.Controls.Add(this.pictureBoxCar);
            this.panelCar.Location = new System.Drawing.Point(147, 3);
            this.panelCar.Name = "panelCar";
            this.panelCar.Size = new System.Drawing.Size(227, 135);
            this.panelCar.TabIndex = 0;
            this.panelCar.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelCar_DragDrop);
            this.panelCar.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelCar_DragEnter);
            // 
            // pictureBoxCar
            // 
            this.pictureBoxCar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCar.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxCar.Name = "pictureBoxCar";
            this.pictureBoxCar.Size = new System.Drawing.Size(216, 123);
            this.pictureBoxCar.TabIndex = 0;
            this.pictureBoxCar.TabStop = false;
            // 
            // ColorgroupBox
            // 
            this.ColorgroupBox.Controls.Add(this.labelDopColor);
            this.ColorgroupBox.Controls.Add(this.labelBaseColor);
            this.ColorgroupBox.Controls.Add(this.panelGreen);
            this.ColorgroupBox.Controls.Add(this.panelBlue);
            this.ColorgroupBox.Controls.Add(this.panelWhite);
            this.ColorgroupBox.Controls.Add(this.panelYellow);
            this.ColorgroupBox.Controls.Add(this.panelRed);
            this.ColorgroupBox.Controls.Add(this.panelBlack);
            this.ColorgroupBox.Controls.Add(this.panelGray);
            this.ColorgroupBox.Controls.Add(this.panelOrange);
            this.ColorgroupBox.Location = new System.Drawing.Point(369, 5);
            this.ColorgroupBox.Name = "ColorgroupBox";
            this.ColorgroupBox.Size = new System.Drawing.Size(216, 159);
            this.ColorgroupBox.TabIndex = 1;
            this.ColorgroupBox.TabStop = false;
            this.ColorgroupBox.Text = "Цвета";
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(108, 16);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(92, 29);
            this.labelDopColor.TabIndex = 6;
            this.labelDopColor.Text = "Доп. цвет";
            this.labelDopColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // labelBaseColor
            // 
            this.labelBaseColor.AllowDrop = true;
            this.labelBaseColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBaseColor.Location = new System.Drawing.Point(11, 16);
            this.labelBaseColor.Name = "labelBaseColor";
            this.labelBaseColor.Size = new System.Drawing.Size(92, 29);
            this.labelBaseColor.TabIndex = 5;
            this.labelBaseColor.Text = "Основной цвет";
            this.labelBaseColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBaseColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
            this.labelBaseColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Green;
            this.panelGreen.Location = new System.Drawing.Point(108, 93);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(40, 40);
            this.panelGreen.TabIndex = 0;
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.Location = new System.Drawing.Point(159, 93);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(40, 40);
            this.panelBlue.TabIndex = 2;
            // 
            // panelWhite
            // 
            this.panelWhite.BackColor = System.Drawing.Color.White;
            this.panelWhite.Location = new System.Drawing.Point(159, 47);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(40, 40);
            this.panelWhite.TabIndex = 4;
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.Location = new System.Drawing.Point(62, 47);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(40, 40);
            this.panelYellow.TabIndex = 3;
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.Location = new System.Drawing.Point(11, 47);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(40, 40);
            this.panelRed.TabIndex = 0;
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.Location = new System.Drawing.Point(108, 47);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(40, 40);
            this.panelBlack.TabIndex = 2;
            // 
            // panelGray
            // 
            this.panelGray.BackColor = System.Drawing.Color.Gray;
            this.panelGray.Location = new System.Drawing.Point(11, 93);
            this.panelGray.Name = "panelGray";
            this.panelGray.Size = new System.Drawing.Size(40, 40);
            this.panelGray.TabIndex = 1;
            // 
            // panelOrange
            // 
            this.panelOrange.BackColor = System.Drawing.Color.Orange;
            this.panelOrange.Location = new System.Drawing.Point(62, 93);
            this.panelOrange.Name = "panelOrange";
            this.panelOrange.Size = new System.Drawing.Size(40, 40);
            this.panelOrange.TabIndex = 0;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(510, 172);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 7;
            this.buttonOk.Text = "Добавить";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(510, 198);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Отменить";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormCarConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.ColorgroupBox);
            this.Controls.Add(this.ParametersgroupBox);
            this.Controls.Add(this.panelCar);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormCarConfig";
            this.Text = "FormCarConfig";
            this.groupBox1.ResumeLayout(false);
            this.ParametersgroupBox.ResumeLayout(false);
            this.ParametersgroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).EndInit();
            this.panelCar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).EndInit();
            this.ColorgroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox ParametersgroupBox;
        private System.Windows.Forms.Label Heightlabel;
        private System.Windows.Forms.Label MaxSpeedlabel;
        private System.Windows.Forms.Panel panelCar;
        private System.Windows.Forms.PictureBox pictureBoxCar;
        private System.Windows.Forms.CheckBox CounterWeightcheckBox;
        private System.Windows.Forms.CheckBox RotaryPlatformcheckBox;
        private System.Windows.Forms.CheckBox BucketcheckBox;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxSpeed;
        private System.Windows.Forms.Label labelCran;
        private System.Windows.Forms.Label labelCar;
        private System.Windows.Forms.GroupBox ColorgroupBox;
        private System.Windows.Forms.Panel panelWhite;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Panel panelGray;
        private System.Windows.Forms.Panel panelOrange;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Label labelBaseColor;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
    }
}