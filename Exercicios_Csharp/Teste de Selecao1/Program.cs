using System;

namespace Teste_de_Selecao1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] valoresString = Console.ReadLine().Split(' ');
            int[] valores = new int[valoresString.Length];

            for (int i = 0; i < valoresString.Length; i++)
            {
                valores[i] = int.Parse(valoresString[i]);
            }

            if ((valores[1] > valores[2])
                && (valores[3] > valores[0])
                && (valores[2] + valores[3]) > (valores[0] + valores[1])
                && (valores[2] >= 0)
                && (valores[3] >= 0)
                && (valores[0] % 2 == 0))
            {
                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }
        }
    }
}
