using System;
using System.Globalization;

namespace Media1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double soma = ((a * 3.5) + (b * 7.5)) / 11;
            Console.WriteLine("MEDIA = " + soma.ToString("F5", CultureInfo.InvariantCulture));
        }
    }
}
