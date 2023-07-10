using System;
using System.Globalization;

namespace Consumo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int km = int.Parse(Console.ReadLine());
            double litros = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine((km / litros).ToString("F3", CultureInfo.InvariantCulture) + " km/l");
        }
    }
}
