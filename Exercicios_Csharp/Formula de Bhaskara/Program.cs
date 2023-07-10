using System;
using System.Globalization;

namespace Formula_de_Bhaskara
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] valoresString = Console.ReadLine().Split(' ');

            double a = 0.0;
            double b = 0.0;
            double c = 0.0;
            double r1 = 0.0;
            double r2 = 0.0;

            a = double.Parse(valoresString[0], CultureInfo.InvariantCulture);
            b = double.Parse(valoresString[1], CultureInfo.InvariantCulture);
            c = double.Parse(valoresString[2], CultureInfo.InvariantCulture);

            double delta = (Math.Pow(b, 2) - (4 * a * c));

            if (a == 0.0 || delta < 0)
            {
                Console.WriteLine("Impossivel calcular");
                return;
            }

            delta = (Math.Sqrt(delta));
            r1 = ((b * (-1)) + delta) / (2.0 * a);
            r2 = ((b * (-1)) - delta) / (2.0 * a);

            Console.WriteLine("R1 = " + r1.ToString("F5", CultureInfo.InvariantCulture));
            Console.WriteLine("R2 = " + r2.ToString("F5", CultureInfo.InvariantCulture));
        }
    }
}
