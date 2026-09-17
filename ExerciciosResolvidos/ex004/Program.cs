using System;
using System.Globalization;

namespace ex004
{
    internal class Program
    {
        #region Enunciado
        /*Fazer um programa para ler o nome (apenas uma palavra) e idade de duas pessoas.
        Ao final mostrar uma mensagem com os nomes e a idade media entre essas pessoas,
        com uma casa decimal, conforme exemplo.*/
        #endregion

        #region Exemplo
        /*entrada
         Maria 19
        Joaquin 20
        
         saída
        A idade média entre Maria e Joaquin é de 19.5 anos*/
        #endregion

        static void Main(string[] args)
        {
            string nome1, nome2;
            int idade1, idade2;
            double media;
            string[] vet;

            Console.Write("Entre com o nome e idade 1: ");
            vet = Console.ReadLine().Split(' ');
            nome1 = vet[0];
            idade1 = int.Parse(vet[1]);

            Console.Write("Entre com o nome e idade 2: ");
            vet = Console.ReadLine().Split(' ');
            nome2 = vet[0];
            idade2 = int.Parse(vet[1]);

            media = (double)(idade1 + idade2) / 2.0;

            Console.WriteLine($"A idade média entre {nome1} e {nome2} é de {media.ToString("F1", CultureInfo.InvariantCulture)} anos");

            Console.ReadKey();
        }
    }
}
