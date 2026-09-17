using System;

namespace ex011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.Write("Entre com o valor de N: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i < 10; i++)
            {
                int x = i * n;
                Console.WriteLine($"{i} x {n} = {x}");
            }

            Console.ReadKey();
        }
    }
}
