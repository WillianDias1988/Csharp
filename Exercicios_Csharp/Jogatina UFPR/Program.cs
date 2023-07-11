using System;

namespace Jogatina_UFPR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] quantidadeEMatricula = Console.ReadLine().Split(' ');
            int quantidade = 0;

            for (int i = 0; i < int.Parse(quantidadeEMatricula[0]); i++)
            {
                string[] registros = Console.ReadLine().Split(' ');
                if (registros[0].Equals(quantidadeEMatricula[1]))
                {
                    if (registros[1].Equals("0"))
                    {
                        quantidade++;
                    }
                }
            }
            Console.WriteLine(quantidade);
            Console.ReadKey();
        }
    }
}
