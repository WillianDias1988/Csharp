using System;
using System.Globalization;

namespace FlutuacaoDoPIB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] entrada = Console.ReadLine().Split(' ');
            double primeiroAno = double.Parse(entrada[0].ToString(),CultureInfo.InvariantCulture);
            double segundoAno = double.Parse(entrada[1].ToString(),CultureInfo.InvariantCulture);
            double soma = ((((primeiroAno / 100) + 1) * ((segundoAno / 100) + 1)) - 1) * 100;
            Console.WriteLine(soma.ToString("F6"));
            Console.ReadKey();
        }
        
    }
}
