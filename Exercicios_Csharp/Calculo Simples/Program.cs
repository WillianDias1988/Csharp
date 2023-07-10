using System;
using System.Globalization;

namespace Calculo_Simples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vProd1 = Console.ReadLine().Split(' ');
            string[] vProd2 = Console.ReadLine().Split(' ');
            double preco1 = (int.Parse(vProd1[1]) * double.Parse(vProd1[2].ToString(), CultureInfo.InvariantCulture));
            double preco2 = (int.Parse(vProd2[1]) * double.Parse(vProd2[2].ToString(), CultureInfo.InvariantCulture));
            double soma = (preco1 + preco2);

            Console.WriteLine("VALOR A PAGAR: R$ " + soma.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
