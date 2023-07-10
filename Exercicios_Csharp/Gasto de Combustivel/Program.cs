using System;
using System.Globalization;

namespace Gasto_de_Combustivel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int horas = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            int distancia = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double combustivel = (distancia / 12.0) * horas;
            Console.WriteLine(combustivel.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
