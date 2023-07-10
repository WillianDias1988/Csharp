using System;

namespace Conversao_de_Tempo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int segundos = int.Parse(Console.ReadLine());
            int horas = 0;
            int minutos = 0;

            if (segundos > 0)
            {
                minutos = (segundos / 60);

                segundos -= (minutos * 60);

                if (minutos > 60)
                {
                    horas = (minutos / 60);
                    minutos -= (horas * 60);

                }
            }

            Console.WriteLine(horas + ":" + minutos + ":" + segundos);
        }
    }
}
