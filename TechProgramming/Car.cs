using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechProgramming
{
    public class Car : Vehicle
    {
        /// <summary>
        /// Ширина отрисовки автомобиля
        /// </summary>
        protected readonly int cranWidth = 200;
        /// <summary>
        /// Высота отрисовки автомобиля
        /// </summary>
        protected readonly int cranHeight = 150;
        /// <summary>
        /// Разделитель для записи информации по объекту в файл
        /// </summary>
        protected readonly char separator = ';';

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        public Car(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }
        /// <summary>
        /// Конструкторс изменением размеров машины
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        /// <param name="cranHeight">Ширина отрисовки автомобиля</param>
        /// <param name="cranHeight">Высота отрисовки автомобиля</param>
        protected Car(int maxSpeed, float weight, Color mainColor, int cranWidth, int cranHeight)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            this.cranWidth = cranWidth;
            this.cranHeight = cranHeight;
        }
        /// <summary>
        /// Конструктор для загрузки с файла
        /// </summary>
        /// <param name="info">Информация по объекту</param>
        public Car(string info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 3)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
            }
        }
        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - cranWidth)
                    {
                        _startPosX += step;
                    }

                    break;
                //влево
                case Direction.Left:
                    // Продумать логику
                    if (_startPosX + step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    // Продумать логику
                    if (_startPosY + step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - cranHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        public override void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);

            // теперь отрисуем основной кузов автомобиля
            //границы автомобиля
            Brush shina = Brushes.Black;
            Brush maincol = new SolidBrush(MainColor);
            g.FillRectangle(maincol, _startPosX + 100, _startPosY + 90, 100, 40);
            g.FillRectangle(maincol, _startPosX + 180, _startPosY + 45, 30, 45);
            g.FillRectangle(maincol, _startPosX + 120, _startPosY + 60, 10, 30);


            g.DrawEllipse(pen, _startPosX + 90, _startPosY + 130, 120, 30);
            g.FillEllipse(shina, _startPosX + 140, _startPosY + 130, 10, 10);
            g.FillEllipse(shina, _startPosX + 160, _startPosY + 130, 10, 10);
            g.FillEllipse(shina, _startPosX + 120, _startPosY + 130, 10, 10);

            g.FillEllipse(shina, _startPosX + 140, _startPosY + 140, 20, 20);
            g.FillEllipse(shina, _startPosX + 120, _startPosY + 140, 20, 20);
            g.FillEllipse(shina, _startPosX + 160, _startPosY + 140, 20, 20);
            g.FillEllipse(shina, _startPosX + 100, _startPosY + 140, 20, 20);
            g.FillEllipse(shina, _startPosX + 180, _startPosY + 140, 20, 20);
        }
        public override string ToString()
        {
            return $"{MaxSpeed}{separator}{Weight}{separator}{MainColor.Name}";
        }
    }
}
