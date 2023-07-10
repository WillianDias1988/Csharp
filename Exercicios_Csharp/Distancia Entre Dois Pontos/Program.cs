using System;
using System.Globalization;

namespace Distancia_Entre_Dois_Pontos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] x1y1 = Console.ReadLine().Split(' ');
            string[] x2y2 = Console.ReadLine().Split(' ');
            double x1 = double.Parse(x1y1[0], CultureInfo.InvariantCulture);
            double y1 = double.Parse(x1y1[1], CultureInfo.InvariantCulture);
            double x2 = double.Parse(x2y2[0], CultureInfo.InvariantCulture);
            double y2 = double.Parse(x2y2[1], CultureInfo.InvariantCulture);
            Console.WriteLine(Math.Sqrt((Math.Pow((x1 - x2), 2) + Math.Pow((y2 - y1), 2))).ToString("F4"), CultureInfo.InvariantCulture);
        }
    }
}
