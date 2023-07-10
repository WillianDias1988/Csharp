using System;
using System.Globalization;

namespace Esfera
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double volume = (4.0 / 3) * 3.14159 * (r * r * r);
            Console.WriteLine("VOLUME = " + volume.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
