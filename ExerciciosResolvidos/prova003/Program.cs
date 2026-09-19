using System;
using System.Globalization;

namespace prova003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Enunciado
            /*Com base na tabela de preços ao lado, faça 
            um programa que leia o código de um item e a 
            quantidade deste item. A seguir, calcule e 
            mostre o valor da conta a pagar. */
            #endregion

            #region Algoritimo
            /* 
            1 - Mostrar uma mensagem pedindo o código do produto
            2 - Ler o código informado
            3 - Pedir a quantidade
            4 - Criar uma variável para armazenar o preço
            5 - Descobrir o preço de acordo com o código
            6 - Calcular o total
            7 - Exibir o resultado
            */
            #endregion

            int codigo, quantidade;
            decimal preco;

            Console.Write("Entre com o codigo e quantidade do produto: ");
            string[] lerValores = Console.ReadLine().Split(' ');

            InformaNumero:
            codigo = int.Parse(lerValores[0]);
            quantidade = int.Parse(lerValores[1]);

            switch (codigo)
            {
                case 1:
                    preco = 4.00M;
                    break;
                case 2:
                    preco = 4.50M;
                    break;
                case 3:
                    preco = 5.00M;
                    break;
                case 4:
                    preco = 2.00M;
                    break;
                case 5:
                    preco = 1.00M;
                    break;

                default:
                    Console.WriteLine("Informe o codigo do produto.");
                goto InformaNumero;
            }

            preco = preco * quantidade;
            Console.WriteLine($"Total = {preco.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.ReadKey();
        }
    }
}
