using System;

namespace Tempo_de_um_Evento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string diaInicio = Console.ReadLine();
            string horarioInicio = Console.ReadLine();
            string diaFim = Console.ReadLine();
            string horarioFim = Console.ReadLine();

            string[] horasInicio = horarioInicio.Replace(" ", "").ToString().Split(':');
            string[] horasFinal = horarioFim.Replace(" ", "").ToString().Split(':');
            TimeSpan diasInicio = TimeSpan.FromDays(double.Parse(diaInicio.Replace("Dia", "")));
            TimeSpan diasFim = TimeSpan.FromDays(double.Parse(diaFim.Replace("Dia", "")));
            TimeSpan horaInicio = TimeSpan.FromHours(double.Parse(horasInicio[0].ToString()));
            TimeSpan minutosInicio = TimeSpan.FromMinutes(double.Parse(horasInicio[1].ToString()));
            TimeSpan segundoInicio = TimeSpan.FromSeconds(double.Parse(horasInicio[2].ToString()));
            TimeSpan horaFinal = TimeSpan.FromHours(double.Parse(horasFinal[0].ToString()));
            TimeSpan minutoFinal = TimeSpan.FromMinutes(double.Parse(horasFinal[1].ToString()));
            TimeSpan segundoFinal = TimeSpan.FromSeconds(double.Parse(horasFinal[2].ToString()));

            TimeSpan dataEHoraInicial = diasInicio.Add(horaInicio.Add(minutosInicio.Add(segundoInicio)));
            TimeSpan dataEHoraFinal = diasFim.Add(horaFinal.Add(minutoFinal.Add(segundoFinal)));

            TimeSpan resulto = dataEHoraFinal - dataEHoraInicial;

            Console.WriteLine($"{resulto.Days} dia(s)");
            Console.WriteLine($"{resulto.Hours} hora(s)");
            Console.WriteLine($"{resulto.Minutes} minuto(s)");
            Console.WriteLine($"{resulto.Seconds} segundo(s)");
        }
    }
}
