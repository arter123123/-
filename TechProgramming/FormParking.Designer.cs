
namespace TechProgramming
{
    partial class FormParking
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
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.PickUpCran = new System.Windows.Forms.GroupBox();
            this.ButtonPickUpCran = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.Place = new System.Windows.Forms.Label();
            this.listBoxParkings = new System.Windows.Forms.ListBox();
            this.textBoxNewLevelName = new System.Windows.Forms.TextBox();
            this.ButtonAddParking = new System.Windows.Forms.Button();
            this.CarPark = new System.Windows.Forms.Label();
            this.ButtonDelParking = new System.Windows.Forms.Button();
            this.buttonSetCar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.PickUpCran.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Location = new System.Drawing.Point(0, 25);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(690, 427);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // PickUpCran
            // 
            this.PickUpCran.Controls.Add(this.ButtonPickUpCran);
            this.PickUpCran.Controls.Add(this.maskedTextBox1);
            this.PickUpCran.Controls.Add(this.Place);
            this.PickUpCran.Location = new System.Drawing.Point(690, 367);
            this.PickUpCran.Name = "PickUpCran";
            this.PickUpCran.Size = new System.Drawing.Size(108, 87);
            this.PickUpCran.TabIndex = 3;
            this.PickUpCran.TabStop = false;
            this.PickUpCran.Text = "Забрать кран";
            // 
            // ButtonPickUpCran
            // 
            this.ButtonPickUpCran.Location = new System.Drawing.Point(9, 52);
            this.ButtonPickUpCran.Name = "ButtonPickUpCran";
            this.ButtonPickUpCran.Size = new System.Drawing.Size(87, 23);
            this.ButtonPickUpCran.TabIndex = 2;
            this.ButtonPickUpCran.Text = "Забрать";
            this.ButtonPickUpCran.UseVisualStyleBackColor = true;
            this.ButtonPickUpCran.Click += new System.EventHandler(this.ButtonPickUpCran_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(51, 26);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(45, 20);
            this.maskedTextBox1.TabIndex = 1;
            // 
            // Place
            // 
            this.Place.AutoSize = true;
            this.Place.Location = new System.Drawing.Point(6, 29);
            this.Place.Name = "Place";
            this.Place.Size = new System.Drawing.Size(42, 13);
            this.Place.TabIndex = 0;
            this.Place.Text = "Место:";
            // 
            // listBoxParkings
            // 
            this.listBoxParkings.FormattingEnabled = true;
            this.listBoxParkings.Location = new System.Drawing.Point(690, 120);
            this.listBoxParkings.Name = "listBoxParkings";
            this.listBoxParkings.Size = new System.Drawing.Size(108, 95);
            this.listBoxParkings.TabIndex = 4;
            this.listBoxParkings.SelectedIndexChanged += new System.EventHandler(this.listBoxParkings_SelectedIndexChanged);
            // 
            // textBoxNewLevelName
            // 
            this.textBoxNewLevelName.Location = new System.Drawing.Point(690, 41);
            this.textBoxNewLevelName.Name = "textBoxNewLevelName";
            this.textBoxNewLevelName.Size = new System.Drawing.Size(108, 20);
            this.textBoxNewLevelName.TabIndex = 5;
            // 
            // ButtonAddParking
            // 
            this.ButtonAddParking.Location = new System.Drawing.Point(690, 67);
            this.ButtonAddParking.Name = "ButtonAddParking";
            this.ButtonAddParking.Size = new System.Drawing.Size(108, 47);
            this.ButtonAddParking.TabIndex = 6;
            this.ButtonAddParking.Text = "Добавить парковку";
            this.ButtonAddParking.UseVisualStyleBackColor = true;
            this.ButtonAddParking.Click += new System.EventHandler(this.ButtonAddParking_Click);
            // 
            // CarPark
            // 
            this.CarPark.AutoSize = true;
            this.CarPark.Location = new System.Drawing.Point(713, 25);
            this.CarPark.Name = "CarPark";
            this.CarPark.Size = new System.Drawing.Size(57, 13);
            this.CarPark.TabIndex = 7;
            this.CarPark.Text = "Парковка";
            // 
            // ButtonDelParking
            // 
            this.ButtonDelParking.Location = new System.Drawing.Point(690, 221);
            this.ButtonDelParking.Name = "ButtonDelParking";
            this.ButtonDelParking.Size = new System.Drawing.Size(108, 23);
            this.ButtonDelParking.TabIndex = 8;
            this.ButtonDelParking.Text = "Удалить парковку";
            this.ButtonDelParking.UseVisualStyleBackColor = true;
            this.ButtonDelParking.Click += new System.EventHandler(this.ButtonDelParking_Click);
            // 
            // buttonSetCar
            // 
            this.buttonSetCar.Location = new System.Drawing.Point(699, 319);
            this.buttonSetCar.Name = "buttonSetCar";
            this.buttonSetCar.Size = new System.Drawing.Size(87, 42);
            this.buttonSetCar.TabIndex = 9;
            this.buttonSetCar.Text = "Добавить автомобиль";
            this.buttonSetCar.UseVisualStyleBackColor = true;
            this.buttonSetCar.Click += new System.EventHandler(this.buttonSetCar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "txt file | *.txt";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "txt file | *.txt";
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSetCar);
            this.Controls.Add(this.ButtonDelParking);
            this.Controls.Add(this.CarPark);
            this.Controls.Add(this.ButtonAddParking);
            this.Controls.Add(this.textBoxNewLevelName);
            this.Controls.Add(this.listBoxParkings);
            this.Controls.Add(this.PickUpCran);
            this.Controls.Add(this.pictureBoxParking);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormParking";
            this.Text = "Стоянка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.PickUpCran.ResumeLayout(false);
            this.PickUpCran.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.GroupBox PickUpCran;
        private System.Windows.Forms.Button ButtonPickUpCran;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label Place;
        private System.Windows.Forms.ListBox listBoxParkings;
        private System.Windows.Forms.TextBox textBoxNewLevelName;
        private System.Windows.Forms.Button ButtonAddParking;
        private System.Windows.Forms.Label CarPark;
        private System.Windows.Forms.Button ButtonDelParking;
        private System.Windows.Forms.Button buttonSetCar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}