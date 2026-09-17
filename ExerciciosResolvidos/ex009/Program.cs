using System;

namespace ex009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            string[] vet = Console.ReadLine().Split(' ');
            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);

            while (a != b)
            {
                if (a > b)
                    Console.WriteLine("Decrescente");
                else
                    Console.WriteLine("Crescente");

                vet = Console.ReadLine().Split(' ');
                a = int.Parse(vet[0]);
                b = int.Parse(vet[1]);
            }
        }
    }
}
