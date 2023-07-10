using System;

namespace Tempo_de_Jogo_com_Minutos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] entrada = Console.ReadLine().ToString().Split(' ');

            TimeSpan horaInicial, minutoInicial, horaFinal, minutoFinal;

            horaInicial = TimeSpan.FromHours(double.Parse(entrada[0].ToString()));
            minutoInicial = TimeSpan.FromMinutes(double.Parse(entrada[1].ToString()));
            horaFinal = TimeSpan.FromHours(double.Parse(entrada[2].ToString()));
            minutoFinal = TimeSpan.FromMinutes(double.Parse(entrada[3].ToString()));

            int horas = horaFinal.Add(minutoFinal).Subtract(horaInicial.Add(minutoInicial)).Hours;
            int minutos = horaFinal.Add(minutoFinal).Subtract(horaInicial.Add(minutoInicial)).Minutes;

            if (horas == 0 && minutos == 0)
            {
                horas = 24;
            }
            else if (horas < 0 || minutos < 0)
            {
                if (horas < 0)
                {
                    horas = horas + 24;
                }
                if (minutos < 0)
                {
                    horas -= 1;
                    if (horas < 0)
                    {
                        horas = horas + 24;
                    }
                    minutos = minutos + 60;
                }
            }


            Console.WriteLine($"O JOGO DUROU {horas} HORA(S) E {minutos} MINUTO(S)");
        }
    }
}
