using System;

namespace Tri_du
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] entrada = Console.ReadLine().Split(' ');
            int carta1 = int.Parse(entrada[0]);
            int carta2 = int.Parse(entrada[1]);

            if (carta1 >= carta2)
            {
                Console.WriteLine(carta1);
            }else if (carta1 <= carta2)
            {
                Console.WriteLine(carta2);
            }

            Console.ReadKey();
        }
    }
}
