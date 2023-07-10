using System;
using System.Globalization;

namespace Tipos_de_Triangulos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] entrada = Console.ReadLine().Split(' ');
            double a = double.Parse(entrada[0], CultureInfo.InvariantCulture);
            double b = double.Parse(entrada[1], CultureInfo.InvariantCulture);
            double c = double.Parse(entrada[2], CultureInfo.InvariantCulture);

            if (a >= (b + c) || b >= (a + c) || c >= (a + b)) { Console.WriteLine("NAO FORMA TRIANGULO"); }
            else if (a * a == (b * b + c * c) || b * b == (a * a + c * c) || c * c == (a * a + b * b)) { Console.WriteLine("TRIANGULO RETANGULO"); }
            else if (a * a > (b * b + c * c) || b * b > (a * a + c * c) || c * c > (a * a + b * b))
            {
                Console.WriteLine("TRIANGULO OBTUSANGULO");
                if (a == b || a == c || c == b) { Console.WriteLine("TRIANGULO ISOSCELES"); }
                else if ((a == b && a != c) || (a == c && a != b) || (b == c && b != a)) { Console.WriteLine("TRIANGULO EQUILATERO"); }
            }
            else if ((a * a < (b * b + c * c) || b * b < (a * a + c * c) || c * c < (a * a + b * b)))
            {
                Console.WriteLine("TRIANGULO ACUTANGULO");
                if ((a == b && a != c) || (a == c && a != b) || (b == c && b != a)) { Console.WriteLine("TRIANGULO ISOSCELES"); }
                else if (a == b && a == c && c == b) { Console.WriteLine("TRIANGULO EQUILATERO"); }

            }
        }
    }
}
