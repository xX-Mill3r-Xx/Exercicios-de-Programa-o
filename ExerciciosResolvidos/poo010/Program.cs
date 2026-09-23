using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Enunciado
            /*A dona de um pensionato possui dez quartos para alugar para estudantes,
            sendo esses quartos identificados pelos números 0 a 9.

            Fazer um programa que inicie com todos os dez quartos vazios, e depois
            leia uma quantidade N representando o número de estudantes que vão
            alugar quartos (N pode ser de 1 a 10). Em seguida, registre o aluguel dos
            N estudantes. Para cada registro de aluguel, informar o nome e email do
            estudante, bem como qual dos quartos ele escolheu (de 0 a 9). Suponha
            que seja escolhido um quarto vago. Ao final, seu programa deve imprimir
            um relatório de todas ocupações do pensionato, por ordem de quarto,
            conforme exemplo.*/
            #endregion

            #region Algoritimo
            /*INÍCIO

            1. Criar uma estrutura para representar os 10 quartos.

            2. Todos os quartos começam vazios.

            3. Perguntar quantos estudantes irão alugar quartos.
               Guardar esse valor em N.

            4. Repetir N vezes:

                  4.1 Ler o nome do estudante.

                  4.2 Ler o email do estudante.

                  4.3 Ler o número do quarto escolhido.

                  4.4 Criar um objeto Estudante
                      contendo nome e email.

                  4.5 Colocar esse estudante
                      na posição correspondente ao quarto escolhido.

            5. Depois que todos os estudantes forem cadastrados,
               percorrer os 10 quartos.

            6. Para cada quarto:

                  Se estiver ocupado:
                      mostrar:
                      número do quarto
                      nome do estudante
                      email do estudante

            FIM*/
            #endregion

            Estudante[] quartosDisponiveis = new Estudante[10];
            

            Console.Write("Quantos quartos serão alugador? ");
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine();
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"Aluguel #{i + 1}: ");
                Console.Write("Nome: ");
                string nomeEstudante = Console.ReadLine();
                Console.Write("Email: ");
                string emailEstudante = Console.ReadLine();

                Estudante estudante = new Estudante
                {
                    Nome = nomeEstudante,
                    Email = emailEstudante,
                };

                Console.Write("Numero do quarto: ");
                int numeroQuarto = int.Parse(Console.ReadLine());

                quartosDisponiveis[numeroQuarto] = estudante;
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Quartos alugados: ");
            for (int i = 0; i < quartosDisponiveis.Length; i++)
            {
                if (quartosDisponiveis[i] != null)
                {
                    Console.WriteLine($"Quarto: {i} | Estudante: {quartosDisponiveis[i].Nome} | Email: {quartosDisponiveis[i].Email}");
                }
            }

            Console.ReadKey();
        }
    }
}
