using System;
using System.Globalization;

namespace Notas_e_Moedas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double nota = 100.00;
            double moeda = 1.00;
            int qtd = 0;
            if (valor >= 0 && valor <= 1000000.00)
            {
                Console.WriteLine("NOTAS:");
                while (valor >= 0)
                {
                    if (nota == 1)
                    {
                        break;
                    }

                    qtd = (int)(valor / nota);
                    valor = valor % nota;
                    valor = Math.Round(valor, 2);
                    Console.WriteLine(qtd + " nota(s) de R$ " + nota.ToString("F2", CultureInfo.InvariantCulture));

                    if ((nota == 50.0) || (nota == 5.0))
                    {
                        nota = nota / 2.50;
                    }
                    else
                    {
                        nota = nota / 2.0;
                    }
                }
                Console.WriteLine("MOEDAS:");
                while (valor >= 0 && valor < 2)
                {

                    qtd = (int)(valor / moeda);
                    valor = valor % moeda;
                    valor = Math.Round(valor, 2);
                    Console.WriteLine(qtd + " moeda(s) de R$ " + moeda.ToString("F2", CultureInfo.InvariantCulture));

                    if (moeda == 0.25)
                    {
                        moeda = moeda / 2.50;
                    }
                    else if (moeda == 0.05)
                    {
                        moeda = 0.01;
                    }
                    else if (moeda <= 0.01)
                    {
                        break;
                    }
                    else
                    {
                        moeda = moeda / 2.0;
                    }
                }
            }
        }
