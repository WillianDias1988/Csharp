using System;

namespace Numeros_Pares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 100)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
            Console.ReadKey();
        }
    }
}
