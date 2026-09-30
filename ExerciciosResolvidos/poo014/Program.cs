using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a quantidade de Funcionários: ");
            int N = int.Parse(Console.ReadLine());

            List<Funcionario> funcionarios = new List<Funcionario>();

            for (int i = 0; i < N; i++)
            {
                Console.Write($"Informe o ID do funcionário #{i + 1}: ");
                int id = int.Parse(Console.ReadLine());

                while (funcionarios.Any(x => x.Id == id))
                {
                    Console.Write($"Informe o ID do funcionário #{i + 1}: ");
                    id = int.Parse(Console.ReadLine());
                }

                Console.Write($"Informe o nome do funcionário #{i + 1}: ");
                string nome = Console.ReadLine();

                Console.Write($"Informe o Salario do funcionário #{i + 1}: ");
                decimal salario = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Funcionario funcionario = new Funcionario(id, nome, salario);

                funcionarios.Add(funcionario);
            }

            Console.WriteLine();

            Console.Write("Informe o ID do funcionário que receberá aumento: ");
            int idAumento = int.Parse(Console.ReadLine());

            Funcionario funcionarioEncontrado = funcionarios.FirstOrDefault(
                    x => x.Id == idAumento);

            if (funcionarioEncontrado == null)
                Console.WriteLine("Este Id não existe.");
            else
            {
                Console.Write("Informe a porcentagem de aumento: ");
                decimal porcentagem = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                funcionarioEncontrado.AumentoSalarial(porcentagem);
            }

            Console.WriteLine();
            Console.WriteLine("Lista Atualizada.");

            foreach (var funcionario in funcionarios)
            {
                Console.WriteLine($"Funcionário: {funcionario.Id}, Nome: {funcionario.Nome}, Salario: R${funcionario.Salario.ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
