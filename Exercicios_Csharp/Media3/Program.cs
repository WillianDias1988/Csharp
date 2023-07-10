using System;
using System.Globalization;

namespace Media3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vNotas = Console.ReadLine().Split(' ');

            double media = Math.Round((((double.Parse(vNotas[0], CultureInfo.InvariantCulture) * 2.0)
                          + (double.Parse(vNotas[1], CultureInfo.InvariantCulture) * 3.0)
                          + (double.Parse(vNotas[2], CultureInfo.InvariantCulture) * 4.0)
                          + (double.Parse(vNotas[3], CultureInfo.InvariantCulture) * 1.0)) / 10.0), 1);

            if (media >= 7.0)
            {
                Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno aprovado.");
            }
            else if (media >= 5.0 && media <= 6.9)
            {
                double notaExame = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno em exame.");
                Console.WriteLine("Nota do exame: "
                    + notaExame.ToString("F1", CultureInfo.InvariantCulture));

                media = Math.Round(((media + notaExame) / 2.0), 1);

                if (media >= 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                    Console.WriteLine("Media final: " + media.ToString("F1", CultureInfo.InvariantCulture));
                }
                else if (media <= 4.9)
                {
                    Console.WriteLine("Aluno reprovado.");
                    Console.WriteLine("Media final: " + media.ToString("F1", CultureInfo.InvariantCulture));
                }

            }
            else if (media <= 4.9)
            {
                Console.WriteLine("Media: " + media.ToString(CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno reprovado.");
            }
        }
    }
}
