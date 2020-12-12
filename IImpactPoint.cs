using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Курсачица
{
    public abstract class IImpactPoint
    {
        public float X;
        public float Y;
        public abstract void ImpactParticle(Particle particle);

        public virtual void Render(Graphics g)
        {
            g.FillEllipse(
                    new SolidBrush(Color.Red),
                    X - 5,
                    Y - 5,
                    10,
                    10
                );
        }
    }

    public class GravityPoint : IImpactPoint
    {
        public HashSet<Particle> numberOfParticles = new HashSet<Particle>(); 
        public int Power = 200;
        public Color rasengan = Color.Red;

        public GravityPoint(Color rasengan)
        {
            this.rasengan = rasengan;
        }
        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;

            double r = Math.Sqrt(gX * gX + gY * gY); // считаем расстояние от центра точки до центра частицы
            if (r + particle.Radius < Power / 2) // если частица оказалось внутри окружности
            {
                var color = particle as ParticleColorful;
                color.FromColor = rasengan;
                color.ToColor = rasengan;
                numberOfParticles.Add(particle);
            }
        }

        public override void Render(Graphics g)
        {
            g.DrawEllipse(
                   new Pen(rasengan),
                   X - Power / 2,
                   Y - Power / 2,
                   Power,
                   Power
               );
            var stringFormat = new StringFormat(); 
            stringFormat.Alignment = StringAlignment.Center; 
            stringFormat.LineAlignment = StringAlignment.Center;
            g.DrawString(
           $"Количество: { numberOfParticles.Count}", 
           new Font("Verdana", 10), 
           new SolidBrush(Color.White), 
           X-20, 
           Y,
           stringFormat
       );
        }
    }
}
