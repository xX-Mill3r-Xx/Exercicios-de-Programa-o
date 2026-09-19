using System;
using System.Globalization;

namespace poo001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Enunciado
            /*Fazer um programa para ler as medidas dos lados de dois triangulos X e Y (ssuponha medidas
            válidas). Em seguida, mostrar o valor das áreas dos dois triângulos e dizer qual dos dois triângulos
            possui a maior área.
            A fórmula para calcular a área de um triângulo a partir das medidas de seus lados a, b e c é a
            seguinte (fórmula de Heron):*/

            // obs.: resolver este problema sem orientação a objetos;

            /*Formula de heron: area = raiz de p(p-a)(p-b)(p-c) onde p = a+b+c / 2*/
            #endregion

            double[] X = new double[3];
            double[] Y = new double[3];
            double pX;
            double pY;
            double areaX;
            double areaY;
            string[] lerValores;

            for (int i = 0; i < 1; i++)
            {
                Console.Write($"Entre com as medidas do triangulo X: ");
                lerValores = Console.ReadLine().Split(' ');

                X[0] = double.Parse(lerValores[0], CultureInfo.InvariantCulture);
                X[1] = double.Parse(lerValores[1], CultureInfo.InvariantCulture);
                X[2] = double.Parse(lerValores[2], CultureInfo.InvariantCulture);
            }

            pX = ((X[0] + X[1] + X[2]) / 2.0);
            areaX = Math.Sqrt((pX * (pX - X[0]) * (pX - X[1]) * (pX - X[2])));

            for (int i = 0; i < 1; i++)
            {
                Console.Write($"Entre com as medidas do triangulo Y: ");
                lerValores = Console.ReadLine().Split(' ');

                Y[0] = double.Parse(lerValores[0], CultureInfo.InvariantCulture);
                Y[1] = double.Parse(lerValores[1], CultureInfo.InvariantCulture);
                Y[2] = double.Parse(lerValores[2], CultureInfo.InvariantCulture);
            }

            pY = ((Y[0] + Y[1] + Y[2]) / 2.0);
            areaY = Math.Sqrt((pY * (pY - Y[0]) * (pY - Y[1]) * (pY - Y[2])));

            Console.WriteLine($"Area de X: {areaX.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Area de Y: {areaY.ToString("F4", CultureInfo.InvariantCulture)}");

            if (areaX > areaY)
                Console.WriteLine($"Maior area = X");
            else
                Console.WriteLine($"Maior area = Y");
        }
    }
}
