using System;

namespace Soma_de_Impares_Consecutivos_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantidadeEntrada = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < quantidadeEntrada; i++)
            {
                int soma = 0;
                string[] valoresEntrada = Console.ReadLine().Split(' ');
                int primeiroValor = int.Parse(valoresEntrada[0]);
                int segundoValor = int.Parse(valoresEntrada[1]);
                if (segundoValor > primeiroValor)
                {
                    for (int j = primeiroValor+1; j < segundoValor; j++)
                    {
                        if (j % 2 == 1)
                        {
                            soma += j;
                        }
                    }
                }
                else
                {
                    for (int k = segundoValor+1; k < primeiroValor; k++)
                    {
                        if (k % 2 == 1)
                        {
                            soma += k;
                        }
                    }
                }
                Console.WriteLine(soma);
               
            }
            Console.ReadKey();
        }
    }
}
