using System;
using System.Globalization;

namespace Triangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] entrada = Console.ReadLine().Split(' ');
            double[] valores = new double[entrada.Length];
            double perimetro = 0.0;
            double area = 0.0;
            double a, b, c = 0.0;

            for (int i = 0; i < entrada.Length; i++)
            {
                valores[i] = double.Parse(entrada[i], CultureInfo.InvariantCulture);
            }
            a = valores[0];
            b = valores[1];
            c = valores[2];

            if ((a + b) > c && (b + c) > a && (c + a) > b)
            {
                perimetro = a + b + c;
                Console.WriteLine("Perimetro = " + perimetro.ToString("F1", CultureInfo.InvariantCulture));
            }
            else
            {
                area = 0.5 * (a + b) * c;
                Console.WriteLine("Area = " + area.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
