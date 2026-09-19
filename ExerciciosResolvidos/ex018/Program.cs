
using System;

namespace ex018
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int linhas, colunas;

            int[,] matriz;

            string[] lerValor = Console.ReadLine().Split(' ');
            linhas = int.Parse(lerValor[0]);
            colunas = int.Parse(lerValor[1]);

            matriz = new int[linhas, colunas];

            for (int percorreLinhas = 0; percorreLinhas < linhas; percorreLinhas++)
            {
                lerValor = Console.ReadLine().Split(' ');
                for (int percorreColunas = 0; percorreColunas < colunas; percorreColunas++)
                {
                    matriz[percorreLinhas, percorreColunas] = int.Parse(lerValor[(percorreColunas)]);
                }
            }

            int[] vetor = new int[linhas];
            for (int percorreLinhas = 0; percorreLinhas < linhas; percorreLinhas++)
            {
                int soma = 0;
                for (int percorreColunas = 0; percorreColunas < colunas; percorreColunas++)
                {
                    soma = soma + matriz[percorreLinhas, percorreColunas];
                }

                vetor[percorreLinhas] = soma;
            }

            for (int i = 0; i < linhas; i++)
            {
                Console.WriteLine(vetor[i]);
            }
        }
    }
}
