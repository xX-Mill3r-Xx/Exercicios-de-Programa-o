using System;

namespace poo015
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;

            N = int.Parse(Console.ReadLine());

            int[,] matrizInteiros = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    matrizInteiros[i, j] = int.Parse(valores[j]);
                }
            }

            Matriz matriz = new Matriz(matrizInteiros);

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.WriteLine(matrizInteiros[i,j]);
                }
            }

            Console.WriteLine("Diagonal principal");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(matrizInteiros[i,i]);
            }

            int cont = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (matrizInteiros[i,j] < 0)
                        cont++;
                }
            }
            Console.WriteLine($"Negativos {cont}");
        }
    }
}
