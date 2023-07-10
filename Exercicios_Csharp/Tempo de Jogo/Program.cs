using System;

namespace Tempo_de_Jogo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] entrada = Console.ReadLine().Split(' ');

            int inicio = int.Parse(entrada[0]);
            int final = int.Parse(entrada[1]);
            int duracao = 0;

            if (inicio == final)
            {
                duracao = 24;
            }
            else if (inicio > final)
            {
                duracao = (24 - inicio) + final;
            }
            else
            {
                duracao = final - inicio;
            }

            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
        }
    }
}
