using System;

namespace PUM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int entradas = int.Parse(Console.ReadLine());
            int contador = 0;
            for (int j = 0; j < entradas; j++)
            {
                for (int i = 0; i < 4; i++)
                {
                    contador++;

                    if (contador % 4 == 0)
                    {
                        Console.Write("PUM\n");

                    }
                    else
                    {
                        Console.Write($"{contador} ");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
