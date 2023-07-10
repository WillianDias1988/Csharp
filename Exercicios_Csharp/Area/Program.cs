using System;
using System.Globalization;

namespace Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] values = Console.ReadLine().Split(' ');
            double areaTringulo = (double.Parse(values[0], CultureInfo.InvariantCulture) * double.Parse(values[2], CultureInfo.InvariantCulture)) / 2;
            double areaCirculo = 3.14159 * (double.Parse(values[2], CultureInfo.InvariantCulture) * double.Parse(values[2], CultureInfo.InvariantCulture));
            double areaTrapezio = (((double.Parse(values[0], CultureInfo.InvariantCulture) + double.Parse(values[1], CultureInfo.InvariantCulture)) / 2 * double.Parse(values[2], CultureInfo.InvariantCulture)));
            double areaQuadrado = double.Parse(values[1], CultureInfo.InvariantCulture) * double.Parse(values[1], CultureInfo.InvariantCulture);
            double areaRetangulo = double.Parse(values[0], CultureInfo.InvariantCulture) * double.Parse(values[1], CultureInfo.InvariantCulture);

            Console.WriteLine("TRIANGULO: " + areaTringulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + areaCirculo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + areaTrapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + areaQuadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + areaRetangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
