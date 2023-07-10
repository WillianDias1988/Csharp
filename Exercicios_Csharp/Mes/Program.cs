using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Mes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int entrada = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Dictionary<int, string> meses = new Dictionary<int, string>();
            meses.Add(1, "January");
            meses.Add(2, "February");
            meses.Add(3, "March");
            meses.Add(4, "April");
            meses.Add(5, "May");
            meses.Add(6, "June");
            meses.Add(7, "July");
            meses.Add(8, "August");
            meses.Add(9, "September");
            meses.Add(10, "October");
            meses.Add(11, "November");
            meses.Add(12, "December");

            if (meses.Keys.Contains(entrada))
            {
                foreach (var mes in meses)
                {
                    if (mes.Key == entrada)
                    {
                        Console.WriteLine(mes.Value);
                    }
                }

            }
        }
    }
}
