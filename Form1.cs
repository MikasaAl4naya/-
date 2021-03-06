﻿using System;
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

        ColorPoint point1;
        ColorPoint point2;
        ColorPoint point3;
        ColorPoint point4;
        ColorPoint point5;
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

            point1 = new ColorPoint(Color.Red)
            {
                X = picDisplay.Width / 2,
                Y = picDisplay.Height / 2,
            };
            point2 = new ColorPoint(Color.LightBlue)
            {
                X = picDisplay.Width / 2 - 250,
                Y = picDisplay.Height / 2,
            };
            point3 = new ColorPoint(Color.Violet)
            {
                X = picDisplay.Width / 2 + 250,
                Y = picDisplay.Height / 2,
            };
            point4 = new ColorPoint(Color.Pink)
            {
                X = picDisplay.Width / 2 - 500,
                Y = picDisplay.Height / 2,
            };
            point5 = new ColorPoint(Color.Yellow)
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


        private void lbY_Scroll(object sender, EventArgs e)
        {
            foreach (var p in emitter.impactPoints)
            {
                if (p is ColorPoint)
                {
                    (p as ColorPoint).Y = lbY.Value;
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
                    if ((p as ColorPoint).Power < 359)
                    {
                        (p as ColorPoint).Power += 10;
                    }
                }
                else if (e.Delta < 0)
                {
                    if ((p as ColorPoint).Power > 10)
                    {
                        (p as ColorPoint).Power -= 10;
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
                lbY.Value = (int)(p as ColorPoint).Y;
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
                if (p is ColorPoint)
                {
                    var a = p as ColorPoint;
                    var x = a.X - e.X;
                    var y = a.Y - e.Y;
                    double r = Math.Sqrt(x * x + y * y);
                    if (r <= a.Power / 2)
                    {
                      (p as ColorPoint).rasengan = button1.BackColor;
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

        private void GravitationBar_Scroll(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            emitter.RadiusMin = trackBar1.Value;
            label6.Text = $"{trackBar1.Value}";
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            emitter.RadiusMax = trackBar2.Value;
            label8.Text = $"{trackBar2.Value}";
        }

        private void GravitaionBar_Scroll(object sender, EventArgs e)
        {                                
                emitter.GravitationY = GravitaionBar.Value;
                label3.Text = $"{GravitaionBar.Value}";         
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                emitter.GravitationY = 0;
            }
            else {
                emitter.GravitationY = GravitaionBar.Value;
                label3.Text = $"{GravitaionBar.Value}";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {               
                emitter = new TopEmitter
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
                    Height = picDisplay.Height-1,
                };

                emitters.Add(this.emitter);
                emitter.GravitationY = -1;
                emitter.impactPoints.Add(point1);
                emitter.impactPoints.Add(point2);
                emitter.impactPoints.Add(point3);
                emitter.impactPoints.Add(point4);
                emitter.impactPoints.Add(point5);
            }
            else
            {
               
                emitter = new TopEmitter
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
                emitter.GravitationY = -1;
                emitter.impactPoints.Add(point1);
                emitter.impactPoints.Add(point2);
                emitter.impactPoints.Add(point3);
                emitter.impactPoints.Add(point4);
                emitter.impactPoints.Add(point5);
                emitter.GravitationY = GravitaionBar.Value;
                label3.Text = $"{GravitaionBar.Value}";
            }
            }
    }
}
