using System;

namespace Ultrapassando_Z
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int primeiroValor = int.Parse(Console.ReadLine());
            bool maior = false;
            int soma = primeiroValor;
            int contador = 1;

            while (maior == false)
            {
                int segundoValor = int.Parse(Console.ReadLine());

                if (segundoValor > primeiroValor)
                {
                    while(soma<= segundoValor)
                    {
                        primeiroValor++;
                        soma+=primeiroValor;
                        contador++;
                    }
                        maior = true;
                    
                }
            }
            Console.WriteLine(contador);
            Console.ReadKey();
        }
    }
}
