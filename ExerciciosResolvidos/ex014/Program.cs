using System;
using System.Globalization;

namespace ex014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Enunciado
            /*Faça um programa que leia N numeros reais e armazene-os em um vetor. Em seguida:
            - Imprimir todos os elementos do vetor
            - Mostrar na tela a soma e a media dos elementos do vetor*/
            #endregion

            #region Algoritimo
            /*
             1 - declarar uma variavel inteira N referente a quantidade do vetor;

            2 - declarar um vetor double

            3 - fazer a leitura da variavel N;

            4 - depois de fazer a leitura de N, o vetor double deve ser alocado com o comando new double[N]

            5 - fazer a leitura do vetor double na mesma linha

            6 - precisamos converter este vetor de string para um vetor de inteiros. Para isso,
            devemos criar um FOR onde i começa com 0; enquanto i for menor que N; i será incrementado

            6.1 - dentro deste FOR o vetor double na posição i deve receber a 
                  conversão do vetor de string na posição i (não esquecer de usar a convenção de ponto e virgula da cultureInfo);

            7 - devemos criar outro FOR onde i começa com 0; enquanto i for menor que N; i será incrementado
            e este servirá para percorrer o vetor double, imprimindo todos os valores;

            7.1 - dentro deste FOR devemos imprimir sem quebra de linha o vetor double na posição i concatenado com espaço em branco;

            8 - ao percorrer todo o vetor, informar uma quebra de linha (Fora do FOR);

            9 - declarar uma variavel double para armazenar a soma e inicia-la com zero

            10 - criar um for percorrendo todas as posições do vetor

            10.1 - dentro deste for, a variavel soma deve receber ela mesma + o vetor double na posição i;

            11 - após percorrer todo este FOR, fora do escopo do FOR, devemos criar uma variavel double para armazenar a media recebendo
                a soma dividido pela quantidade (que neste caso é o N)

            12 - mostrar o resultado de soma com duas casas decimais

            13 - mostrar o resultado de media com duas casas decimais
             */
            #endregion

            int N;
            double[] vetorDouble;

            N = int.Parse(Console.ReadLine());
            vetorDouble = new double[N];

            string[] vetorString = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                vetorDouble[i] = double.Parse(vetorString[i], CultureInfo.InvariantCulture);
            }

            for (int i = 0; i < N; i++)
            {
                Console.Write($"{vetorDouble[i].ToString("F1", CultureInfo.InvariantCulture)} ");
            }
            Console.WriteLine();

            double soma = 0.0;

            for (int i = 0; i < N; i++)
            {
                soma = soma + vetorDouble[i];
            }

            double media = soma / N;
            Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}
