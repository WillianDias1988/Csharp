using System;

namespace Pares_entre_Cinco_Numeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            for (int i = 0; i < 5; i++)
            {
                int entrada = int.Parse(Console.ReadLine());
                if (entrada%2==0)
                {
                    contador++;
                }
            }
            Console.WriteLine($"{contador} valores pares");
        }
    }
}
