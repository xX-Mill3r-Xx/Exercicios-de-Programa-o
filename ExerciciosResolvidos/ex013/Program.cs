using System;

namespace ex013
{
    internal class Program
    {
        #region Enunciado
        /*Faça um programa que leia N numeros inteiros e armazene-os em um vetor. Em
        seguida, mostrar na tela todos os números negativos lidos.*/
        #endregion

        #region Algoritimo
        /*
            1 - declara uma variavel inteira N
            2 - declarar um vetor de inteiros
            3 - ler a variavel N
            4 - depois da leitura de N, instanciar o vetor de inteiros recebendo um new int[N]
            5 - criar um vetor de string para ler os numeros na mesma linha
            6 - precisamos converter este vetor de string para um vetor de inteiros. Para isso,
            devemos criar um FOR onde i começa com 0; enquanto i for menor que N; i será incrementado
            6.1 - dentro deste FOR o vetor de inteiros na posição i deve receber a 
                  conversão do vetor de string na posição i
            7 - devemos criar outro FOR onde i começa com 0; enquanto i for menor que N; i será incrementado
            e este servirá para percorrer o vetor de inteiros, imprimindo somente os negativos
            7.1 - dentro deste for colocamos uma condição onde:
                  se o vetor inteiro na posição i for menor que zero
                  imprimimos este vetor na posição i
         */
        #endregion

        static void Main(string[] args)
        {
            Console.Write("Informe o valor de N: ");
            int N;
            int[] vetorInteiros;

            N = int.Parse(Console.ReadLine());
            Console.Write($"Digite os {N} numeros na mesma linha: ");
            vetorInteiros = new int[N];
            string[] vetorString = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                vetorInteiros[i] = int.Parse(vetorString[i]);
            }

            Console.WriteLine("Os numeros negativos são: ");
            for (int i = 0; i < N; i++)
            {
                if (vetorInteiros[i] < 0)
                {
                    Console.WriteLine(vetorInteiros[i]);
                }
            }

            Console.ReadKey();
        }
    }
}
