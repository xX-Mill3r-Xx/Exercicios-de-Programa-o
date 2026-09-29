using System;

namespace poo011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Enunciado
            /*Fazer uma calculadora usando classe e objetos para retornar a soma entre N valores*/
            #endregion

            Console.Write("Entre com a quantidade de numeros que deseja somar: ");
            int N = int.Parse(Console.ReadLine());

            Console.Write("Digite os numeros separados por virgula, em seguida, tecle enter para confirmar: ");
            string[] entrada = Console.ReadLine().Split(',');

            int[] valores = new int[N];

            for (int i = 0; i < N; i++)
            {
                valores[i] = int.Parse(entrada[i].Trim());
            }

            int result = Calculator.Sum(valores);

            Console.WriteLine($"A soma dos numeros digitados é: {result}");
        }
    }
}
