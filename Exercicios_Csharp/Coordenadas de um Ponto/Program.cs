using System;
using System.Globalization;

namespace Coordenadas_de_um_Ponto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] entrada = Console.ReadLine().Split(' ');
            double x = double.Parse(entrada[0], CultureInfo.InvariantCulture);
            double y = double.Parse(entrada[1], CultureInfo.InvariantCulture);

            if (x == 0.0 && y == 0.0)
            {
                Console.WriteLine("Origem");
            }
            else if (x == 0.0 && y != 0.0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (x != 0.0 && y == 0.0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (x < 0.0 && y > 0.0)
            {
                Console.WriteLine("Q2");
            }
            else if (x > 0.0 && y < 0.0)
            {
                Console.WriteLine("Q4");
            }
            else if (x < 0.0 && y < 0.0)
            {
                Console.WriteLine("Q3");
            }
            else if (x > 0.0 && y > 0.0)
            {
                Console.WriteLine("Q1");
            }
        }
    }
}
