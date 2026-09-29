using System;
using System.Collections.Generic;
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

            foreach (var f in funcionarios)
            {
                f.Id = int.Parse(Console.ReadLine());
                if(f.Id == funcionarios.FindIndex(x => x.Id == f.Id))
                {
                    Console.WriteLine("Id Inválido, informe outro ID");
                    return;
                }
                else
                {
                    f.Nome = Console.ReadLine();
                    decimal aumento = f.AlmentoSalarial(3);

                    Funcionario funcionario = new Funcionario
                    {
                        Id = f.Id,
                        Nome = f.Nome,
                    };

                    funcionarios.Add(funcionario);
                }    
            }

            foreach (var f in funcionarios)
            {

            }
        }
    }
}
