using System;
using System.Globalization;

namespace Imposto_de_Renda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double entrada = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double resto = 0, taxa = 0;

            if (entrada <= 2000.00)
            {
                Console.WriteLine("Isento");
            }
            else
            {
                if (entrada > 2000.00 && entrada <= 3000.00)
                {
                    entrada += -2000.00;
                    taxa = (entrada * 8.00)/100.00;
                }
                else if (entrada > 3000.00 && entrada <= 4500.00)
                {
                    resto = 1000.00;
                    taxa = (resto * 8.00) /100.00;
                    entrada += -3000.00;
                    taxa += (entrada * 18.00)/100.00;
                }
                else if (entrada > 4500.00)
                {
                    resto = 1000.00;
                    taxa = (resto * 8.00) / 100.00;
                    resto = 1500.00;
                    taxa += (resto * 18.00) /100.00;
                    entrada += -4500.00;
                    taxa += (entrada * 28.00) /100.00;
                }
                Console.WriteLine($"R$ {taxa.ToString("F2")}");
            }
        }
    }
}
