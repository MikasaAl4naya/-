using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace particles
{
    public abstract class IImpactPoint
    {
        public float X; // ну точка же, вот и две координаты
        public float Y;
        

        // абстрактный метод с помощью которого будем изменять состояние частиц
        // например притягивать
        public abstract void ImpactParticle(Particle particle);

        // базовый класс для отрисовки точечки
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
        int count = 0;
        public HashSet<Particle> numberOfParticles = new HashSet<Particle>(); 
        public int Power = 200; // сила притяжения
        public Color rasengan = Color.Red;
        public GravityPoint(Color rasengan)
        {
            this.rasengan = rasengan;
        }
        // а сюда по сути скопировали с минимальными правками то что было в UpdateState
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
            // буду рисовать окружность с диаметром равным Power
            g.DrawEllipse(
                   new Pen(rasengan),
                   X - Power / 2,
                   Y - Power / 2,
                   Power,
                   Power
               );
            g.DrawString(
           $"Количество: { numberOfParticles.Count}", // надпись, можно перенос строки вставлять (если вы Катя, то может не работать и надо использовать \r\n)
           new Font("Verdana", 10), // шрифт и его размер
           new SolidBrush(Color.White), // цвет шрифта
           X-20, // расположение в пространстве
           Y
       );
        }
    }
}
