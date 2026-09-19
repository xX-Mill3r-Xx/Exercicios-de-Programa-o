using System;
using System.Globalization;

namespace prova001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Enunciado
            /*
            Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o 
            código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.*/
            #endregion

            #region Algoritimo
            /* 
            1 - declarar uma variavel inteira codigo;
            2 - declarar uma varivael inteira numero;
            3 - declarar uma variavel decimal preço;
            4 - percorrer as linhas informando os valores na mesma linha;
            5 - calcular o valor a ser pago;
            6 - mostrar o preço a ser pago
            */
            #endregion

            int codigo, numeroDePecas;
            decimal preco;
            decimal soma = 0M;

            for (int i = 0; i <= 1; i++)
            {
                string[] lerValores = Console.ReadLine().Split(' ');
                codigo = int.Parse(lerValores[0]);
                numeroDePecas = int.Parse(lerValores[1]);
                preco = decimal.Parse(lerValores[2], CultureInfo.InvariantCulture);

                preco = preco * numeroDePecas;
                soma = soma + preco;
            }

            Console.WriteLine($"Valor a pagar: {soma.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
