using System;

namespace Identificando_o_Cha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tipoDoCha = int.Parse(Console.ReadLine());
            string[] respostas = Console.ReadLine().Split(' ');
            int acertos = 0;
            for (int i = 0; i < respostas.Length; i++)
            {
                if (int.Parse(respostas[i]) == tipoDoCha)
                {
                    acertos++;
                }
            }
            Console.WriteLine(acertos);
        }
    }
}
