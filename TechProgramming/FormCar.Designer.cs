
namespace TechProgramming
{
    partial class FormCar
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCar));
            this.ButtonCreate = new System.Windows.Forms.Button();
            this.ButtonUp = new System.Windows.Forms.Button();
            this.ButtonLeft = new System.Windows.Forms.Button();
            this.ButtonDown = new System.Windows.Forms.Button();
            this.ButtonRight = new System.Windows.Forms.Button();
            this.pictureBoxCars = new System.Windows.Forms.PictureBox();
            this.ButtonModCar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCars)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonCreate
            // 
            resources.ApplyResources(this.ButtonCreate, "ButtonCreate");
            this.ButtonCreate.Name = "ButtonCreate";
            this.ButtonCreate.UseVisualStyleBackColor = true;
            this.ButtonCreate.Click += new System.EventHandler(this.ButtonCreate_Click);
            // 
            // ButtonUp
            // 
            resources.ApplyResources(this.ButtonUp, "ButtonUp");
            this.ButtonUp.BackgroundImage = global::TechProgramming.Properties.Resources.upp;
            this.ButtonUp.Name = "ButtonUp";
            this.ButtonUp.UseVisualStyleBackColor = true;
            this.ButtonUp.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // ButtonLeft
            // 
            resources.ApplyResources(this.ButtonLeft, "ButtonLeft");
            this.ButtonLeft.BackgroundImage = global::TechProgramming.Properties.Resources.left2;
            this.ButtonLeft.Name = "ButtonLeft";
            this.ButtonLeft.UseVisualStyleBackColor = true;
            this.ButtonLeft.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // ButtonDown
            // 
            resources.ApplyResources(this.ButtonDown, "ButtonDown");
            this.ButtonDown.BackgroundImage = global::TechProgramming.Properties.Resources.down1;
            this.ButtonDown.Name = "ButtonDown";
            this.ButtonDown.UseVisualStyleBackColor = true;
            this.ButtonDown.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // ButtonRight
            // 
            resources.ApplyResources(this.ButtonRight, "ButtonRight");
            this.ButtonRight.Name = "ButtonRight";
            this.ButtonRight.UseVisualStyleBackColor = true;
            this.ButtonRight.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // pictureBoxCars
            // 
            resources.ApplyResources(this.pictureBoxCars, "pictureBoxCars");
            this.pictureBoxCars.Name = "pictureBoxCars";
            this.pictureBoxCars.TabStop = false;
            // 
            // ButtonModCar
            // 
            resources.ApplyResources(this.ButtonModCar, "ButtonModCar");
            this.ButtonModCar.Name = "ButtonModCar";
            this.ButtonModCar.UseVisualStyleBackColor = true;
            this.ButtonModCar.Click += new System.EventHandler(this.ButtonModCar_Click);
            // 
            // FormCar
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ButtonModCar);
            this.Controls.Add(this.ButtonUp);
            this.Controls.Add(this.ButtonLeft);
            this.Controls.Add(this.ButtonDown);
            this.Controls.Add(this.ButtonRight);
            this.Controls.Add(this.ButtonCreate);
            this.Controls.Add(this.pictureBoxCars);
            this.Name = "FormCar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCars)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCars;
        private System.Windows.Forms.Button ButtonCreate;
        private System.Windows.Forms.Button ButtonRight;
        private System.Windows.Forms.Button ButtonDown;
        private System.Windows.Forms.Button ButtonLeft;
        private System.Windows.Forms.Button ButtonUp;
        private System.Windows.Forms.Button ButtonModCar;
    }
}

