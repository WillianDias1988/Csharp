using System;

namespace Idades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            double somaIdade = 0;
            int quantidade = 0;

            while (continuar)
            {
                int entrada = int.Parse(Console.ReadLine());
                if (entrada < 0)
                {
                    continuar = false;
                    break;
                }
                else
                {
                    somaIdade += entrada;
                    quantidade++;
                }
            }
            somaIdade /= quantidade;
            Console.WriteLine($"{somaIdade.ToString("F2")}");
        }
    }
}
