using System;

namespace Triangulo
{
    class TrianguloArea
    {
        public double a;
        public double b;
        public double c;


        public double Area()
        {
            double p = (a + b + c) / 2.0;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

    }
}
