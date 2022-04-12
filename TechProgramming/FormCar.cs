﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechProgramming
{
    public partial class FormCar : Form
    {
        private ITransport car;
        public FormCar()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Передача машины на форму
        /// </summary>
        /// <param name="car"></param>
        public void SetCar(ITransport car)
        {
            this.car = car;
            Draw();
        }

        /// Метод отрисовки машины
        /// </summary>
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxCars.Width, pictureBoxCars.Height);
            Graphics gr = Graphics.FromImage(bmp);
            car?.DrawTransport(gr);
            pictureBoxCars.Image = bmp;
        }
        /// <summary>
        /// Обработка нажатия кнопки "Создать автомобиль"
        /// </summary>

        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            car = new Car(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue);
            car.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxCars.Width, pictureBoxCars.Height);
            Draw();

        }

        /// <summary>
        /// Обработка нажатия кнопки "Создать гоночный автомобиль"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonModCar_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            car = new Cran(rnd.Next(200, 300), rnd.Next(1000, 2000), Color.Blue, Color.Yellow, true, true, true);
            car.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxCars.Width, pictureBoxCars.Height);
            Draw();

        }
        /// <summary>
        /// Обработка нажатия кнопок управления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = (sender as Button).Name;
            switch (name)
            {
                case "ButtonUp":
                    car?.MoveTransport(Direction.Up);
                    break;
                case "ButtonDown":
                    car?.MoveTransport(Direction.Down);
                    break;
                case "ButtonLeft":
                    car?.MoveTransport(Direction.Left);
                    break;
                case "ButtonRight":
                    car?.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }


    }
}