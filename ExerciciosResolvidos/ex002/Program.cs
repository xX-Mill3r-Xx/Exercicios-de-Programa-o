using System;

namespace ex002
{
    internal class Program
    {
        #region Enunciado
        /*Leia 2 valores inteirosl e armazene-os nas variáveis A e B. Efetue a soma de A e B atribuindo o seu resultado na
        variável X. Imprima X conforme exemplo apresentado abaixo.*/
        #endregion

        #region Exemplo
        /*entrada
        a = 10
        b = 9
        
         saída
        x = 19*/
        #endregion

        static void Main(string[] args)
        {
            Console.Write("Entre com o valor A: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Entre com o valor B: ");
            int b = int.Parse(Console.ReadLine());

            int x = a + b;

            Console.Write($"Valor de X: {x}");

            Console.ReadKey();
        }
    }
}
