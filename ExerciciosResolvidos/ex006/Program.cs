using System;
using System.Globalization;

namespace ex006
{
    internal class Program
    {
        #region Enunciado
        /*Fazer um programa para ler as duas notas que um aluno obteve no primeiro e
        segundo semestres de uma disciplina anual. Em seguida, mostrar a nota final que o
        aluno obteve no ano juntamente com um texto explicativo. Caso a nota final do aluno
        seja inferior a 60.00, mostrar a mensagem "REPROVADO", conforme exemplos. Todos
        os valores devem ter uma casa decimal.*/
        #endregion

        #region Exemplo
        /*entrada
         45.5
        31.3
        
         saida
        Nota Final = 76.8*/
        #endregion

        static void Main(string[] args)
        {
            double nota1, nota2, soma;
            const double notaMinima = 60.0;

            Console.Write("Entre com o valor da nota 1: ");
            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Entre com o valor da nota 2: ");
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            soma = nota1 + nota2;

            Console.WriteLine($"Nota Final: {soma.ToString("F1", CultureInfo.InvariantCulture)}");

            if (soma < notaMinima)
                Console.WriteLine("Reprovado");

            Console.ReadKey();
        }
    }
}
