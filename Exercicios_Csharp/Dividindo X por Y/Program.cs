using System;
using System.Globalization;

namespace Dividindo_X_por_Y
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantidade = int.Parse(Console.ReadLine());
            double primeiroNumero = 0;
            double segundoNumero = 0;
            double resultado = 0;
            
            for (int i = 0; i < quantidade; i++)
            {
                string[] entrada = Console.ReadLine().Split(' ');
                primeiroNumero = double.Parse(entrada[0].ToString(),CultureInfo.InvariantCulture);
                segundoNumero = double.Parse(entrada[1].ToString(),CultureInfo.InvariantCulture);
                if (segundoNumero.Equals(0))
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    resultado = primeiroNumero / segundoNumero;
                    Console.WriteLine(resultado.ToString("F1"));
                }

                Console.ReadKey();
            }
        }
    }
}
