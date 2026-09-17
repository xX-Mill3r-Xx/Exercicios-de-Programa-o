using System;
using System.Globalization;

namespace ex001
{
    internal class Program
    {
        #region Enunciado
        /*Fazer um programa para ler as medidas da largura e comprimento de um terreno
        retangular com uma casa decimal, bem como o valor do metro quadrado do terreno
        com duas casas decimais. Em seguida, o programa deve mostrar o valor da área do
        terreno, bem como o valor do preço do terreno, ambos com duas casas decimais,
        conforme exemplo.*/
        #endregion

        #region Exemplo
        /*entrada
        largura = 10.0
        comprimento = 30.0
        preço do metro quadrado = 200.00
        
         saída
        area = 300.00
        preço = 60000.00*/
        #endregion

        #region Formula
        /*área = largura x comprimento
        preço = área x preço do metro quadrado*/
        #endregion

        static void Main(string[] args)
        {
            Console.Write("Entre com a largura do terreno: ");
            double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Entre com o comprimento do terreno: ");
            double comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Informe o preço do Metro Quadrado: ");
            double precoMetroQuadrado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = largura * comprimento;
            double preco = area * precoMetroQuadrado;

            Console.WriteLine($"Área: {area.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Preço: {preco.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.ReadKey();
        }
    }
}
