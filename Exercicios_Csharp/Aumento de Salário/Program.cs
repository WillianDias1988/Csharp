using System;
using System.Globalization;

namespace Aumento_de_Salário
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario = double.Parse(Console.ReadLine().ToString(), CultureInfo.InvariantCulture);
            int porcentagem = 0;
            double reajuste = 0, novoSalario = 0;

            if (salario > 2000.00)
            {
                porcentagem = 4;
                reajuste = ((salario * porcentagem) / 100);
                novoSalario = salario + reajuste;

            }
            else if (salario >= 1200.01)
            {
                porcentagem = 7;
                reajuste = ((salario * porcentagem) / 100);
                novoSalario = salario + reajuste;

            }
            else if (salario >= 800.01)
            {
                porcentagem = 10;
                reajuste = ((salario * porcentagem) / 100);
                novoSalario = salario + reajuste;
            }
            else if (salario >= 400.01)
            {
                porcentagem = 12;
                reajuste = ((salario * porcentagem) / 100);
                novoSalario = salario + reajuste;
            }
            else if (salario > 0)
            {
                porcentagem = 15;
                reajuste = ((salario * porcentagem) / 100);
                novoSalario = salario + reajuste;
            }

            Console.WriteLine($"Novo salario: {novoSalario.ToString("F2")}");
            Console.WriteLine($"Reajuste ganho: {reajuste.ToString("F2")}");
            Console.WriteLine($"Em percentual: {porcentagem} %");
        }
    }
}
