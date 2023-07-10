using System;

namespace Idade_em_Dias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dias = int.Parse(Console.ReadLine());
            int ano = 0;
            int mes = 0;

            ano = dias / 365;
            dias -= 365 * ano;
            mes = dias / 30;
            dias -= 30 * mes;

            Console.WriteLine(ano + " ano(s)");
            Console.WriteLine(mes + " mes(es)");
            Console.WriteLine(dias + " dia(s)");
        }
    }
}
