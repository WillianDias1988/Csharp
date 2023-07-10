using System;
using System.Collections.Generic;
using System.Linq;

namespace DDD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ddd = int.Parse(Console.ReadLine().ToString());
            Dictionary<int, string> tabela = new Dictionary<int, string>();
            tabela.Add(61, "Brasilia");
            tabela.Add(71, "Salvador");
            tabela.Add(11, "Sao Paulo");
            tabela.Add(21, "Rio de Janeiro");
            tabela.Add(32, "Juiz de Fora");
            tabela.Add(19, "Campinas");
            tabela.Add(27, "Vitoria");
            tabela.Add(31, "Belo Horizonte");

            if (tabela.Keys.Contains(ddd))
            {
                foreach (var key in tabela)
                {
                    if (key.Key == ddd)
                    {
                        Console.WriteLine(key.Value.ToString());
                    }
                }
            }
            else
            {
                Console.WriteLine("DDD nao cadastrado");
            }

            Console.ReadKey();
        }
    }
}
