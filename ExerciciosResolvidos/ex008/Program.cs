using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.Write("Entre com valores para a, b e c na mesma linha: ");
            string[] vet = Console.ReadLine().Split(' ');
            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);
            c = int.Parse(vet[2]);

            if (a < b && a < c)
                Console.WriteLine($"Menor: {a}");
            else if (b < c)
                Console.WriteLine($"Menor: {b}");
            else
                Console.WriteLine($"Menor: {c}");

            Console.ReadKey();
        }
    }
}
