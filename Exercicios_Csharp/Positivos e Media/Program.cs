using System;
using System.Globalization;

namespace Positivos_e_Media
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double soma = 0;
            double entrada;
            int contador = 0;

            for (int i = 0; i < 6; i++)
            {
                entrada = double.Parse(Console.ReadLine().ToString(),CultureInfo.InvariantCulture);
                if (entrada > 0) {
                    soma += entrada;
                    contador++;
                }
            }
            Console.WriteLine($"{contador} valores positivos");
            soma = soma / contador;
            Console.WriteLine($"{soma.ToString("F1")}");
        }
    }
}
