using System;
using System.Globalization;

namespace Salario_com_Bonus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = Console.ReadLine();
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double vendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("TOTAL = R$ " + ((vendas * 0.15) + salary).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
