using System;

namespace Sort_Simples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] entrada = Console.ReadLine().Split(' ');
            int[] vInteiro = new int[entrada.Length];
            int j, menor = 0;

            for (int i = 0; i < entrada.Length; i++)
            {
                vInteiro[i] = int.Parse(entrada[i]);
            }


            for (int i = 1; i < vInteiro.Length; i++)
            {

                menor = vInteiro[i];

                j = i;

                while ((j > 0) && (vInteiro[j - 1] > menor))

                {

                    vInteiro[j] = vInteiro[j - 1];

                    j = j - 1;

                }

                vInteiro[j] = menor;

            }

            for (int i = 0; i < vInteiro.Length; i++)
            {
                Console.WriteLine(vInteiro[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < entrada.Length; i++)
            {
                Console.WriteLine(entrada[i]);
            }

            Console.ReadKey();
        }
    }
}
