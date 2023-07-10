using System;
using System.Globalization;

namespace Lanche
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] pedido = Console.ReadLine().Split(' ');

            double valor = 0.0;

            if (int.Parse(pedido[0]) == 1)
            {
                valor = 4.0;
            }
            else if (int.Parse(pedido[0]) == 2)
            {
                valor = 4.5;
            }
            else if (int.Parse(pedido[0]) == 3)
            {
                valor = 5.0;
            }
            else if (int.Parse(pedido[0]) == 4)
            {
                valor = 2.0;
            }
            else if (int.Parse(pedido[0]) == 5)
            {
                valor = 1.5;
            }

            valor *= int.Parse(pedido[1]);

            Console.WriteLine("Total: R$ " + valor.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
