using System;

namespace Simulacija
{
    public class telo
    {
        public float x, y;
        public double vx, vy;
        public double fx, fy;
        public float r;
        public double m;
        private double dt = 1E-5;
        private double f;
        private double G;
        public double rmultp = 1;
    public telo() {  }
    public void setc(double a)
        {
            G = a;
        }
    public double rastojanje(telo a)
        {
            double ras;
            ras = Math.Sqrt(Math.Pow((x - a.x), 2) + Math.Pow((y - a.y),2));
            return ras*rmultp;
        }
    public double sila(telo a)
        {
            f = G * m * a.m / Math.Pow(rastojanje(a),2);
            double ugao = Math.Atan(Math.Abs((a.y - y) / (a.x - x)));
            int c = 1;
            if (a.x < x) c = -1;
            fx = Math.Cos(ugao) * f * c;
            c = 1;
            if (a.y < y) c = -1;
            fy = Math.Sin(ugao) * f * c;
            brzina();
            return f;
        }
    private void brzina()
        {
            vx += fx * dt / m;
            vy += fy * dt / m;
        }
    public bool sudar(telo a)
        {
            bool lol=false;
            if (rastojanje(a)/rmultp <= a.r/a.rmultp || a.rastojanje(this)/a.rmultp <= r/rmultp)
            {
                lol = true;
            }
            return lol;
        }
    }
}
