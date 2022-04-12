using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TechProgramming
{
    public class Cran : Car
    {
        /// <summary>
        /// Основной цвет кузова
        /// </summary>
        /// <summary>
        /// Дополнительный цвет
        /// </summary>
        public Color DopColor { private set; get; } //
        /// <summary>
        /// Признак наличия переднего спойлера
        /// </summary>
        public bool CounterWeight { private set; get; } //
        /// <summary>
        /// Признак наличия боковых спойлеров
        /// </summary>
        /// <summary>
        /// Признак наличия заднего спойлера
        /// </summary>
        public bool Bucket { private set; get; } //
        /// <summary>
        /// Признак наличия гоночной полосы
        /// </summary>
        public bool RotaryPlatform { private set; get; }
        /// <summary>
        /// Инициализация свойств
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        /// <param name="dopColor">Дополнительный цвет</param>
        /// <param name="counterweight">Признак наличия переднего спойлера</param>
        /// <param name="bucket">Признак наличия заднего спойлера</param>
        /// <param name="rotaryplatform">Признак наличия гоночной полосы</param>
        public Cran(int maxSpeed, float weight, Color mainColor, Color dopColor,
       bool counterweight, bool bucket, bool rotaryplatform) :
        base(maxSpeed, weight, mainColor, 100, 60)
        {
            DopColor = dopColor;
            CounterWeight = counterweight;
            Bucket = bucket;
            RotaryPlatform = rotaryplatform;
        }
        /// <summary>
        /// Конструктор для загрузки с файла
        /// </summary>
        /// <param name="info"></param>
        public Cran(string info) : base(info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 7)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                CounterWeight = Convert.ToBoolean(strs[4]);
                Bucket = Convert.ToBoolean(strs[5]);
                RotaryPlatform = Convert.ToBoolean(strs[6]);
            }
        }

        public override void DrawTransport(Graphics g)
        {
            Brush br = new SolidBrush(MainColor);

            base.DrawTransport(g);
            if (CounterWeight)
            {
                Brush spoiler = new SolidBrush(DopColor);

                g.FillRectangle(spoiler, _startPosX + 190, _startPosY + 120, 20, 30);

            }
            // рисуем гоночные полоски
            if (RotaryPlatform)
            {
                br = new SolidBrush(DopColor);
                g.FillRectangle(br, _startPosX + 180, _startPosY + 80, 20, 10);
            }
            // рисуем ковш
            if (Bucket)
            {
                Brush spoiler = new SolidBrush(DopColor);
                g.FillRectangle(spoiler, _startPosX + 100, _startPosY + 80, 10, 12);
                g.FillRectangle(spoiler, _startPosX + 40, _startPosY + 60, 100, 10);
                g.FillRectangle(spoiler, _startPosX + 40, _startPosY + 60, 5, 30);
                g.FillRectangle(spoiler, _startPosX + 20, _startPosY + 90, 50, 50);

            }
        }
        /// <summary>
        /// Смена дополнительного цвета
        /// </summary>
        /// <param name="color"></param>
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }
        public override string ToString()
        {
            return $"{base.ToString()}{separator}{DopColor.Name}{separator}{CounterWeight}{separator}{Bucket}{separator}{RotaryPlatform}";
        }


    }
}

