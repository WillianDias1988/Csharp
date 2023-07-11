using System;

namespace Crescente_e_Decrescente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            while (contador<1)
            {
                string[] valoresDeEntrada = Console.ReadLine().Split(' ');
                int primeiroValor = int.Parse(valoresDeEntrada[0]);
                int segundoValor = int.Parse(valoresDeEntrada[1]);

                if (primeiroValor == segundoValor)
                {
                    contador++;
                }
                else
                {
                    if (primeiroValor > segundoValor)
                    {
                        Console.WriteLine("Decrescente");
                        continue;
                    }
                    else if (segundoValor > primeiroValor)
                    {
                        Console.WriteLine("Crescente");
                        continue;
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
