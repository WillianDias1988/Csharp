using System;
using System.Globalization;

namespace Numeros_Positivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] entrada = new double[6];
            int contador = 0;
            for (int i = 0; i < entrada.Length; i++)
            {
                double data = double.Parse(Console.ReadLine().ToString(), CultureInfo.InvariantCulture);
                if (data > 0)
                {
                    contador++;
                }
            }

            Console.WriteLine($"{contador} valores positivos");
            Console.ReadKey();
        }
    }
}
