using System;
using System.Globalization;

namespace ex003
{
    internal class Program
    {
        #region Enunciado
        /*Fazer um programa para ler as medidas da base e altura de um retângulo. Em
        seguida, mostrar o valor da área, perímetro e diagonal deste retângulo, com quatro
        casas decimais, conforme exemplo.*/
        #endregion

        #region Exemplo
        /*entrada
        5.0
        4.0
        
         saída
        Area = 20.0000
        Perimetro = 18.000
        Diagonal = 6.4031*/
        #endregion

        #region Formula
        /*área = base x altura
         perimetro = 2 x base + 2 x altura
        diagonal = raiz quadrada de base elevada ao quadrado + altura elevada ao quadrado*/
        #endregion

        static void Main(string[] args)
        {
            Console.Write("Entre com o valor da base: ");
            double baseR = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Entre com o valor da altura: ");
            double alturaR = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = baseR * alturaR;
            double perimetro = (2 * baseR) + (2 * alturaR);
            double diagonal = Math.Sqrt(Math.Pow(baseR, 2) + Math.Pow(alturaR, 2));

            Console.WriteLine($"ÁREA: {area.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"PERIMETRO: {perimetro.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"DIAGONAL: {diagonal.ToString("F4", CultureInfo.InvariantCulture)}");

            Console.ReadKey();
        }
    }
}
