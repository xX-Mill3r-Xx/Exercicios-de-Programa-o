using System;
using System.Globalization;

namespace prova004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Enunciado
            /*Ler os valores dos três coeficientes "a", "b" e "c" de uma equação do segundo grau (ax ao quadrado + bx + c = 0) 
            Em seguida, mostrar os valores das raízes da equação, conforme exemplos, usando a fórmula de Baskara (veja 
            abaixo). Se a equação não possuir raízes (o valor de "a" não pode ser zero, e o valor de "delta" não pode ser 
            negativo), mostrar uma mensagem "Impossivel calcular". */
            #endregion

            #region Algoritimo
            /*
            1 - ler as variaveis a, b, c
            2 - calcular delta
            3 - verificar se é possivel continuar
                3.1 - se a for igual a 0 = impossivel calcular
                3.2 - senão, delta for menor que 0 = impossivel calcular
                3.3 - senão = calcular x1, x2 e mostrar x1, x2;
            */
            #endregion

            double a, b, c, delta, x1, x2;

            string[] lerValores = Console.ReadLine().Split(' ');
            a = double.Parse(lerValores[0], CultureInfo.InvariantCulture);
            b = double.Parse(lerValores[1], CultureInfo.InvariantCulture);
            c = double.Parse(lerValores[2], CultureInfo.InvariantCulture);

            delta = (Math.Pow(b, 2)) - (4 * a * c);

            if (a == 0)
                Console.WriteLine("Impossível Calcular.");
            else if (delta < 0)
                Console.WriteLine("Impossível Calcular.");
            else
            {
                x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

                Console.WriteLine($"X1: {x1.ToString("F5", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"X2: {x2.ToString("F5", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
