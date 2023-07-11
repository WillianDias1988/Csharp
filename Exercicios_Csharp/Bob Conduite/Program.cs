using System;

namespace Bob_Conduite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantidade = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 0;
            for (int i = 0; i < quantidade; i++)
            {
                string[] entrada = Console.ReadLine().Split(' ');
                a = int.Parse(entrada[0]);
                b = int.Parse(entrada[1]);
                Console.WriteLine($"{a + b}");
            }

            Console.ReadKey();
        }
    }
}
