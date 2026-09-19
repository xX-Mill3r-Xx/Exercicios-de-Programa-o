using po004;
using System;
using System.Globalization;

namespace poo004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Enunciado
            /*Continuação do exercicio anterior
             
             - Criar uma classe para representar melhor o triangulo*/
            #endregion

            TrianguloX X = new TrianguloX();
            TrianguloY Y = new TrianguloY();
            double areaX;
            double areaY;
            string[] lerValores;

            for (int i = 0; i < 1; i++)
            {
                Console.Write($"Entre com as medidas do triangulo X: ");
                lerValores = Console.ReadLine().Split(' ');

                X.A = double.Parse(lerValores[0], CultureInfo.InvariantCulture);
                X.B = double.Parse(lerValores[1], CultureInfo.InvariantCulture);
                X.C = double.Parse(lerValores[2], CultureInfo.InvariantCulture);
            }

            areaX = CalculoTriangulo.RetornaAreaX(X);

            for (int i = 0; i < 1; i++)
            {
                Console.Write($"Entre com as medidas do triangulo Y: ");
                lerValores = Console.ReadLine().Split(' ');

                Y.A = double.Parse(lerValores[0], CultureInfo.InvariantCulture);
                Y.B = double.Parse(lerValores[1], CultureInfo.InvariantCulture);
                Y.C = double.Parse(lerValores[2], CultureInfo.InvariantCulture);
            }

            areaY = CalculoTriangulo.RetornaAreaY(Y);

            Console.WriteLine($"Area de X: {areaX.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Area de Y: {areaY.ToString("F4", CultureInfo.InvariantCulture)}");

            if (areaX > areaY)
                Console.WriteLine($"Maior area = X");
            else
                Console.WriteLine($"Maior area = Y");
        }
    }
}
