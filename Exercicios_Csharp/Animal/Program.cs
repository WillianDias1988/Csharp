using System;

namespace Animal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string palavra1 = Console.ReadLine().ToLower();
            string palavra2 = Console.ReadLine().ToLower();
            string palavra3 = Console.ReadLine().ToLower();
            string animal = string.Empty;
            if (palavra1.Equals("vertebrado"))
            {
                if (palavra2.Equals("ave"))
                {
                    if (palavra3.Equals("carnivoro"))
                    {
                        animal = "aguia";
                    }
                    else
                    {
                        animal = "pomba";
                    }
                }
                else
                {
                    if (palavra3.Equals("onivoro"))
                    {
                        animal = "homem";
                    }
                    else
                    {
                        animal = "vaca";
                    }
                }

            }
            else
            {
                if (palavra2.Equals("inseto"))
                {
                    if (palavra3.Equals("hematofago"))
                    {
                        animal = "pulga";
                    }
                    else
                    {
                        animal = "lagarta";
                    }
                }
                else
                {
                    if (palavra3.Equals("hematofago"))
                    {
                        animal = "sanguessuga";
                    }
                    else
                    {
                        animal = "minhoca";
                    }
                }
            }

            Console.WriteLine(animal);
        }
    }
}
