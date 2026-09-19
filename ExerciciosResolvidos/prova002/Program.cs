using System;
using System.Globalization;

namespace prova002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Enunciado
            /*Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro 
                casas decimais conforme exemplos. 
 
                Fórmula: area = π.raio ao quadrado
 
                Considere o valor de π = 3.14159 */
            #endregion

            #region Algoritimo
            /*
            1 - declarar uma variavel double raio
            2 - declarar uma variavel double area
            3 - declarar uma constante double para pi
            4 - calcular a area do circulo
            5 - mostrar a area do circulo com 4 casas decimais*/
            #endregion

            const double pi = 3.14159;

            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double area = pi * Math.Pow(raio, 2);

            Console.WriteLine($"A = {area.ToString("F4", CultureInfo.InvariantCulture)}");
        }
    }
}
