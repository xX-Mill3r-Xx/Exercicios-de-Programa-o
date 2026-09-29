using System;

namespace poo012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Enunciado
            /*Criar uma calculadora que triplique o valor de um numero passado. Obs.: Usar ref*/
            #endregion

            Console.Write("Informe o valor a ser triplicado: ");
            int valor = int.Parse(Console.ReadLine());

            int triplo = Calculator.Triple(ref valor);

            Console.WriteLine($"O valor digitado quando triplicado é: {triplo}");
        }
    }
}
