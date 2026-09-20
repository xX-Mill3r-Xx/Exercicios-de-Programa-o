using System;
using System.Globalization;

namespace poo006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Enunciado
            /*Faça um programa para ler a cotação do dólar, e depois um valor em dólares a ser comprado por
            uma pessoa em reais. Informar quantos reais a pessoa vai pagar pelos dolares, considerando ainda
            que a pessoa tera que pagar 6% de IOF sobre o valor em dolar. Criar uma classe ConversorDeMoeda
            para ser responsável pelos cálculos.*/
            #endregion

            Console.Write("Qual a cotação do dolar? ");
            decimal cotacao = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dolares voce vai comprar? ");
            decimal quantia = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            decimal resultado = ConversorDeMoeda.Converter(quantia, cotacao);

            Console.Write($"Valor a ser pago em reais: {resultado.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
