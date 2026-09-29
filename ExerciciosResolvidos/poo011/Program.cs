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

            int result = Calculator.Sum(new int[] { 10, 20, 30, 40 });

            Console.WriteLine(result);
        }
    }
}
