using System;

namespace prova006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Enunciado
            /*Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida. 
            Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando 
            essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo). */
            #endregion

            int N, dentro, fora;
            dentro = 0;
            fora = 0;

            Console.Write("Entre com o valor de N: ");
            N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                int X = int.Parse(Console.ReadLine());
                if (X < 10 || X > 20)
                    fora++;
                else
                    dentro++;
            }

            Console.WriteLine($"In: {dentro}");
            Console.WriteLine($"Out: {fora}");

            Console.ReadKey();
        }
    }
}
