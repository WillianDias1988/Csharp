using System;

namespace Produto_Simples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int prod = a * b;
            if (a == 0 || b == 0)
            {
                prod = 0;
            }
            Console.WriteLine("PROD = " + prod);
        }
    }
}
