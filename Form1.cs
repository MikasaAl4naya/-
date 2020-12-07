using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace particles
{
    public partial class Form1 : Form
    {
        Emitter emitter; //эммитер без явного создания
        public static Random rand = new Random();
        List<Emitter> emitters = new List<Emitter>();
        List<Particle> particles = new List<Particle>();

        GravityPoint point1; // добавил поле под первую точку
        GravityPoint point2; // добавил поле под вторую точку
        GravityPoint point3;
        GravityPoint point4;
        GravityPoint point5;
        public Form1()
        {
            InitializeComponent();

            // привязали к пикчбоку изображения, чтоб можно было рисовать
            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);
            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);
            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);

            this.emitter = new TopEmitter // создаю эмиттер и привязываю его к полю emitter
            {
                Direction = 0,
                Spreading = 10,
                SpeedMin = 10,
                SpeedMax = 10,
                ColorFrom = Color.White,
                ColorTo = Color.FromArgb(0, Color.White),
                ParticlesPerTick = 20,
                X = picDisplay.Width / 2,
                Width = picDisplay.Width,
                Y = picDisplay.Height / 2,
            };

            emitters.Add(this.emitter); // все равно добавляю в список emitters, чтобы он рендерился и обновлялся

            point1 = new GravityPoint(Color.Red)
            {
                X = picDisplay.Width / 2,
                Y = picDisplay.Height / 2,
            };
            point2 = new GravityPoint(Color.LightBlue)
            {
                X = picDisplay.Width / 2 - 250,
                Y = picDisplay.Height / 2,
            };
            point3 = new GravityPoint(Color.Violet)
            {
                X = picDisplay.Width / 2 + 250,
                Y = picDisplay.Height / 2,
            };
            point4 = new GravityPoint(Color.Pink)
            {
                X = picDisplay.Width / 2 - 500,
                Y = picDisplay.Height / 2,
            };
            point5 = new GravityPoint(Color.Yellow)
            {
                X = picDisplay.Width / 2 + 500,
                Y = picDisplay.Height / 2,
            };

            // привязываем поля к эмиттеру
            emitter.impactPoints.Add(point1);
            emitter.impactPoints.Add(point2);
            emitter.impactPoints.Add(point3);
            emitter.impactPoints.Add(point4);
            emitter.impactPoints.Add(point5);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            emitter.UpdateState(); // обновляем систему каждый тик 

            using (var g = Graphics.FromImage(picDisplay.Image))
            {
                g.Clear(Color.Black); // здесь задаем цвет фона
                emitter.Render(g); // Рендерим нашу кучу частицы
            }

            picDisplay.Invalidate(); //очень важный момент - обновляем picDisplay
        }


        // направление струи
        private void tbDirection_Scroll(object sender, EventArgs e)
        {
            emitter.Direction = tbDirection.Value;
            lblDirection.Text = $"{tbDirection.Value}°"; // вывод значения
        }



        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                emitter.GravitationY = 0;
            }

            if (radioButton1.Checked)
            {
                emitter.GravitationY = 1;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tbEllipse_Scroll(object sender, EventArgs e)
        {
            foreach (var p in emitter.impactPoints)
            {
                if (p is GravityPoint) // так как impactPoints не обязательно содержит поле Power, надо проверить на тип 
                {
                    // если гравитон то меняем силу
                    (p as GravityPoint).Power = tbEllipse.Value;
                }
            }
        }

        private void lbY_Scroll(object sender, EventArgs e)
        {
            foreach (var p in emitter.impactPoints)
            {
                if (p is GravityPoint) // так как impactPoints не обязательно содержит поле Power, надо проверить на тип 
                {
                    (p as GravityPoint).Y = lbY.Value;
                }
            }
        }

        private void CngColor_Click(object sender, EventArgs e)
        {
            emitter.impactPoints.Remove(point1);
            emitter.impactPoints.Remove(point2);
            emitter.impactPoints.Remove(point3);
            emitter.impactPoints.Remove(point4);
            emitter.impactPoints.Remove(point5);
            point1 = new GravityPoint(Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255)))
            {
                X = picDisplay.Width / 2,
                Y = picDisplay.Height / 2,
            };
            point2 = new GravityPoint(Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255)))
            {
                X = picDisplay.Width / 2 - 250,
                Y = picDisplay.Height / 2,
            };
            point3 = new GravityPoint(Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255)))
            {
                X = picDisplay.Width / 2 + 250,
                Y = picDisplay.Height / 2,
            };
            point4 = new GravityPoint(Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255)))
            {
                X = picDisplay.Width / 2 - 500,
                Y = picDisplay.Height / 2,
            };
            point5 = new GravityPoint(Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255)))
            {
                X = picDisplay.Width / 2 + 500,
                Y = picDisplay.Height / 2,
            };
            emitter.impactPoints.Add(point1);
            emitter.impactPoints.Add(point2);
            emitter.impactPoints.Add(point3);
            emitter.impactPoints.Add(point4);
            emitter.impactPoints.Add(point5);

        }
    }   
}
