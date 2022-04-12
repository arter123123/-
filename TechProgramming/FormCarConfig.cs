using System;
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
    public partial class FormCarConfig : Form
    {
        /// <summary>
        /// Переменная-выбранная машина
        /// </summary>

        Car car = null;
        /// <summary>
        /// Событие
        /// </summary>
        private event Action<Car> eventAddCar;
        /// <summary>
        /// Добавление события
        /// </summary>
        public void AddEvent(Action<Car> ev)
        {
            eventAddCar += ev;
        }
        public FormCarConfig()
        {
            InitializeComponent();
            // привязать panelColor_MouseDown к панелям с цветами
            panelRed.MouseDown += panelColor_MouseDown;
            panelYellow.MouseDown += panelColor_MouseDown;
            panelBlack.MouseDown += panelColor_MouseDown;
            panelWhite.MouseDown += panelColor_MouseDown;
            panelGray.MouseDown += panelColor_MouseDown;
            panelOrange.MouseDown += panelColor_MouseDown;
            panelGreen.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown;
            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }
        /// <summary>
        /// Отрисовать машину
        /// </summary>
        private void DrawCar()
        {
            if (car != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxCar.Width, pictureBoxCar.Height);
                Graphics gr = Graphics.FromImage(bmp);
                car.SetPosition(-15, -40, pictureBoxCar.Width, pictureBoxCar.Height);
                car.DrawTransport(gr);
                pictureBoxCar.Image = bmp;
            }
        }
        /// <summary>
        /// Отправляем цвет с панели
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }


        /// <summary>
        /// Передаем информацию при нажатии на Label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelCar_MouseDown(object sender, MouseEventArgs e)
        {
            labelCar.DoDragDrop(labelCar.Text, DragDropEffects.Move | DragDropEffects.Copy);

        }
        /// <summary>
        /// Передаем информацию при нажатии на Label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelCran_MouseDown(object sender, MouseEventArgs e)
        {
            labelCran.DoDragDrop(labelCran.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }
        /// <summary>
        /// Проверка получаемой информации (ее типа на соответствие требуемому)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            // Прописать логику проверки приходящего значения на тип Color
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
        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            // Прописать логику смены базового цвета
            if (car != null)
            {
                car.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawCar();
            }
        }
        /// <summary>
        /// Принимаем дополнительный цвет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            // Прописать логику смены дополнительного цвета, если объект является
            //объектом дочернего класса
            if (car != null)
            {
                if (car is Cran)
                {
                    (car as Cran).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawCar();
                }
            }
        }
        /// <summary>
        /// Проверка получаемой информации (ее типа на соответствие требуемому)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void panelCar_DragEnter(object sender, DragEventArgs e)
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
        private void panelCar_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Обычный кран":
                    car = new Car((int)numericUpDownMaxSpeed.Value, (int)numericUpDownWeight.Value, Color.White);
                    break;
                case "Модифицированный кран":
                    car = new Cran((int)numericUpDownMaxSpeed.Value, (int)numericUpDownWeight.Value, Color.White, Color.Black, CounterWeightcheckBox.Checked, BucketcheckBox.Checked, RotaryPlatformcheckBox.Checked);
                    break;
            }
            DrawCar();
        }
       


        /// <summary>
        /// Добавление машины
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOk_Click(object sender, EventArgs e)
        {
            eventAddCar?.Invoke(car);
            Close();

        }
    }
}
