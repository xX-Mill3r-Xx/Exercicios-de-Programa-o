using System;
using System.Collections.Generic;

namespace poo003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Enunciado
            /*Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais
            velha.*/
            #endregion

            int quantidade = 2;
            List<Pessoa> pessoas = new List<Pessoa>();

            for (int i = 0; i < quantidade; i++)
            {
                Pessoa pessoa = new Pessoa();
                Console.Write($"Entre com o nome da pessoa {i + 1}: ");
                pessoa.Nome = Console.ReadLine();

                Console.Write($"Entre com a idade da pessoa {i + 1}: ");
                pessoa.Idade = int.Parse(Console.ReadLine());

                pessoas.Add(pessoa);
            }

            Pessoa maisVelha = pessoas[0];

            for (int i = 0; i < pessoas.Count; i++)
            {
                if (pessoas[i].Idade > maisVelha.Idade)
                    maisVelha = pessoas[i];
            }

            Console.WriteLine($"Mais velha: {maisVelha.Nome}");
        }
    }
}
