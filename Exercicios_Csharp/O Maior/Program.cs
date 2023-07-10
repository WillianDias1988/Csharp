using System;

namespace O_Maior
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vInteiro = Console.ReadLine().Split(' ');
            int maiorAB = (int.Parse(vInteiro[0]) + int.Parse(vInteiro[1]) + Math.Abs(int.Parse(vInteiro[0]) - int.Parse(vInteiro[1]))) / 2;
            int maiorABC = (maiorAB + int.Parse(vInteiro[2]) + Math.Abs(maiorAB - int.Parse(vInteiro[2]))) / 2;
            Console.WriteLine(maiorABC + " eh o maior");
        }
    }
}
