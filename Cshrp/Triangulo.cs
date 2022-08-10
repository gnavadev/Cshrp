using System;
using System.Globalization;


namespace Triangulo
{
    class Triangulo
    {
        static void TrianguloMain(string[] args)
        {
            TrianguloArea x, y;

            x = new TrianguloArea();
            y = new TrianguloArea();

            Console.WriteLine("Entre com as medidas do Triangulo X: ");
            x.a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Entre com as medidas do Triangulo Y: ");
            y.a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area();
            double areaY = y.Area();

            System.Console.WriteLine($"Area de X: {areaX}");
            System.Console.WriteLine($"Area de Y: {areaY}");



        }
    }
}