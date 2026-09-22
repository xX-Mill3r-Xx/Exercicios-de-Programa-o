using System;
using System.Collections.Generic;
using System.Globalization;

namespace poo008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Enunciado
            /*Crie uma classe Pessoa com as propriedades Nome, Idade e Altura. Adicione:

                Um construtor parametrizado

                Um método Apresentar() que exibe no console: "Olá, meu nome é X, tenho Y anos e Z m de altura."

                No Main, crie 3 pessoas diferentes e chame Apresentar() para cada uma.*/
            #endregion

            List<Pessoa> pessoas = new List<Pessoa>();
            int quantidadePessoas = 3;

            for (int i = 0; i < quantidadePessoas; i++)
            {
                Console.Write($"Informe Nome, Idade e Altura da pessoa {i + 1}: ");
                string[] pessoa = Console.ReadLine().Split(' ');
                pessoas.Add(new Pessoa
                {
                    Nome = pessoa[0],
                    Idade = int.Parse(pessoa[1]),
                    Altura = double.Parse(pessoa[2], CultureInfo.InvariantCulture)
                });
            }

            foreach (var pessoa in pessoas)
            {
                pessoa.Apresentar();
            }
        }
    }
}
