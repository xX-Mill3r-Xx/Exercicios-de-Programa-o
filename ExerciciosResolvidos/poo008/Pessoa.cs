using System;
using System.Globalization;

namespace poo008
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public double Altura { get; set; }

        public Pessoa()
        {

        }

        public Pessoa(string nome, int idade, double altura)
        {
            Nome = nome;
            Idade = idade;
            Altura = altura;
        }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos e {Altura.ToString("F2", CultureInfo.InvariantCulture)}m de altura.");
        }
    }
}
