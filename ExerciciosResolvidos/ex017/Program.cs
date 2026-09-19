using System;

namespace ex017
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declarar uma variavel interia N;
            int N;

            // declarar a matriz
            int[,] matriz;

            // ler a variavel N
            N = int.Parse(Console.ReadLine());

            // instanciar a matriz com [N] linhas e [N] colunas;
            matriz = new int[N, N];

            // fazer a leitura dos numeros e armazenar na matriz
            for (int i = 0; i < N; i++) // linha
            {
                string[] s = Console.ReadLine().Split(' ');

                for (int j = 0; j < N; j++) // coluna
                {
                    matriz[i, j] = int.Parse(s[j]);
                }
            }

            // mostar a diagonal principal da matriz
            Console.WriteLine("Diagonal Principal: ");
            for (int i = 0; i < N; i++)
            {
                Console.Write($"{matriz[i, i]} ");
            }
            Console.WriteLine();

            // mostrar a quantidade de numeros negativos
            int cont = 0;
            for (int i = 0;i < N; i++) // linha
            {
                for (int j = 0; j < N; j++) // coluna
                {
                    if (matriz[i,j] < 0)
                        cont++;
                }
            }
            Console.WriteLine($"Quantidade de negativos: {cont}");
        }
    }
}
