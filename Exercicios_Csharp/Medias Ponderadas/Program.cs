using System;
using System.Globalization;

namespace Medias_Ponderadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantidade = int.Parse(Console.ReadLine());
            for (int i = 0; i < quantidade ; i++)
            {
                string[] entrada = Console.ReadLine().Split(' ');
                double n1 = double.Parse(entrada[0].ToString(),CultureInfo.InvariantCulture); 
                double n2 = double.Parse(entrada[1].ToString(),CultureInfo.InvariantCulture); 
                double n3 = double.Parse(entrada[2].ToString(),CultureInfo.InvariantCulture);
                double soma = ((n1 * 2.0) + (n2 * 3.0) + (n3 * 5.0)) / (2.0+3.0+5.0);
                Console.WriteLine(soma.ToString("F1"));
            }
            Console.ReadKey();
        }
    }
}
