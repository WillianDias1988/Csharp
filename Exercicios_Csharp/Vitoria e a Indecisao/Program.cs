using System;
using System.Collections.Generic;

namespace Vitoria_e_a_Indecisao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int QuantidadeDeEntradas = int.Parse(Console.ReadLine());
            List<string> lista = new List<string>();
            for (int i = 0;i< QuantidadeDeEntradas;i++)
            {
                lista.Add(Console.ReadLine());
            }

            Random random = new Random();
            Console.WriteLine(lista[random.Next(QuantidadeDeEntradas)]);
            Console.ReadKey();
        }
    }
}
