using System;
using System.Globalization;

namespace Salario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            double valueHours = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NUMBER = " + number);
            Console.WriteLine("SALARY = U$ " + (valueHours * hours).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
