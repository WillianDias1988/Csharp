using System;
using System.Globalization;

namespace Media2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture) * 2;
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture) * 3;
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture) * 5;

            double media = (a + b + c) / 10;

            Console.WriteLine("MEDIA = " + media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
