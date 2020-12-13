using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсачица
{
    public partial class Form1 : Form
    {
        Emitter emitter; //эммитер без явного создания
        public static Random rand = new Random();
        List<Emitter> emitters = new List<Emitter>();
        bool work = true;

        GravityPoint point1;
        GravityPoint point2;
        GravityPoint point3;
        GravityPoint point4;
        GravityPoint point5;
        public Form1()
        {
            InitializeComponent();
            picDisplay.MouseWheel += new MouseEventHandler(picDisplay_MouseWheel);
            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);
            this.emitter = new TopEmitter
            {
                Direction = 0,
                Spreading = 10,
                SpeedMin = 10,
                SpeedMax = 10,
                ColorFrom = Color.White,
                ParticlesPerTick = 20,
                X = picDisplay.Width / 2,
                Width = picDisplay.Width,
                Y = picDisplay.Height / 2,
            };

            emitters.Add(this.emitter);

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
            emitter.impactPoints.Add(point1);
            emitter.impactPoints.Add(point2);
            emitter.impactPoints.Add(point3);
            emitter.impactPoints.Add(point4);
            emitter.impactPoints.Add(point5);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            emitter.Chidori();
            if (work == true)
            emitter.UpdateState(); // обновляем систему каждый тик 

            using (var g = Graphics.FromImage(picDisplay.Image))
            {
                g.Clear(Color.Black); 
                emitter.Render(g);
            }

            foreach(var p in emitter.particles)
            {
                if (p.X > picDisplay.Width || p.Y > picDisplay.Height ||p.X<0 ||p.Y<0)
                {
                    p.Life = 0;
                }
            }

            picDisplay.Invalidate();
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

        private void lbY_Scroll(object sender, EventArgs e)
        {
            foreach (var p in emitter.impactPoints)
            {
                if (p is GravityPoint)
                {
                    (p as GravityPoint).Y = lbY.Value;
                }
            }
        }

        private void CngColor_Click(object sender, EventArgs e)
        {
            point1.rasengan = Color.Red;
            point2.rasengan = Color.LightBlue;
            point3.rasengan = Color.Violet;
            point4.rasengan = Color.Pink;
            point5.rasengan = Color.Yellow;
        }

        private void picDisplay_MouseWheel(object sender, MouseEventArgs e)
        {
            foreach (var p in emitter.impactPoints)
            {
                if (e.Delta > 0)
                {
                    if ((p as GravityPoint).Power < 359)
                    {
                        (p as GravityPoint).Power += 10;
                    }
                }
                else if (e.Delta < 0)
                {
                    if ((p as GravityPoint).Power > 10)
                    {
                        (p as GravityPoint).Power -= 10;
                    }
                }
            }
        }

        private void lbCount_Scroll(object sender, EventArgs e)
        {
            emitter.ParticlesPerTick = lbCount.Value;
            label5.Text = Convert.ToString(lbCount.Value);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label5.Text = Convert.ToString(lbCount.Value);
            foreach (var p in emitter.impactPoints)
                lbY.Value = (int)(p as GravityPoint).Y;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                button1.BackColor  = dialog.Color;
            }
        }

        private void picDisplay_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (var p in emitter.impactPoints)
            {
                if (p is GravityPoint)
                {
                    var a = p as GravityPoint;
                    var x = a.X - e.X;
                    var y = a.Y - e.Y;
                    double r = Math.Sqrt(x * x + y * y);
                    if (r <= a.Power / 2)
                    {
                      (p as GravityPoint).rasengan = button1.BackColor;
                        break;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            work = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            work = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            emitter.UpdateState();
        }
    }
}
