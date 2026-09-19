using po002;
using System;
using System.Globalization;

namespace poo002
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
            double pX;
            double pY;
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

            pX = ((X.A + X.B + X.C) / 2.0);
            areaX = Math.Sqrt((pX * (pX - X.A) * (pX - X.B) * (pX - X.C)));

            for (int i = 0; i < 1; i++)
            {
                Console.Write($"Entre com as medidas do triangulo Y: ");
                lerValores = Console.ReadLine().Split(' ');

                Y.A = double.Parse(lerValores[0], CultureInfo.InvariantCulture);
                Y.B = double.Parse(lerValores[1], CultureInfo.InvariantCulture);
                Y.C = double.Parse(lerValores[2], CultureInfo.InvariantCulture);
            }

            pY = ((Y.A + Y.B + Y.C) / 2.0);
            areaY = Math.Sqrt((pY * (pY - Y.A) * (pY - Y.B) * (pY - Y.C)));

            Console.WriteLine($"Area de X: {areaX.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Area de Y: {areaY.ToString("F4", CultureInfo.InvariantCulture)}");

            if (areaX > areaY)
                Console.WriteLine($"Maior area = X");
            else
                Console.WriteLine($"Maior area = Y");
        }
    }
}
