using System;
using System.Globalization;

namespace Intervalo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (valor >= 0 && valor <= 25.0000)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (valor >= 25.00001 && valor <= 50.000000)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (valor >= 50.0000001 && valor <= 75.00000000)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else if (valor >= 75.000000001 && valor <= 100.0000000000)
            {
                Console.WriteLine("Intervalo (75,100]");
            }
            else
            {
                Console.WriteLine("Fora de intervalo");
            }
        }
    }
}
