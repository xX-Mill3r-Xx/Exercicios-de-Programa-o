using System;

namespace poo013
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Enunciado
            /*Fazer uma calculadora que triplique o valor passado. Obs.: Usar out*/
            #endregion

            Console.Write("Entre com o valor a ser triplicado: ");
            int valor = int.Parse(Console.ReadLine());
            int triple;

            int result = Calculator.Triple(valor, out triple);

            Console.WriteLine($"O valor digitado quando triplicado é: {triple}");
        }
    }
}
