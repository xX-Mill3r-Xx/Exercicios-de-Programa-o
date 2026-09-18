using System;
using System.Globalization;

namespace ex015
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o valor de N: ");
            int N = int.Parse(Console.ReadLine());

            string[] nomes = new string[N];
            int[] idade = new int[N];
            double[] alturas = new double[N];

            double somaIAlturas = 0.0;
            int menores16 = 0;

            string[] vetorString;
            for (int i = 0; i < N; i++)
            {
                vetorString = Console.ReadLine().Split(' ');
                nomes[i] = vetorString[0];
                idade[i] = int.Parse(vetorString[1]);
                alturas[i] = double.Parse(vetorString[2], CultureInfo.InvariantCulture);
                somaIAlturas = somaIAlturas + alturas[i];

                if (idade[i] < 16)
                    menores16++;
            }

            double alturaMedia = somaIAlturas / N;
            double porcentagem = menores16 * 100.0 / N;

            Console.WriteLine($"Altura média das pessoas: {alturaMedia.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Porcentagem com menos de 16 anos: {porcentagem.ToString("F1", CultureInfo.InvariantCulture)}%");
        }
    }
}
