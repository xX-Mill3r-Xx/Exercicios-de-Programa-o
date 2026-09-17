using System;

namespace ex005
{
    internal class Program
    {
        #region Enunciado
        /*Leia um valor inteiro N, que é o tempo de duração em segundos de um determinado evento em uma fábrica, e
        informe-o expresso no formato horas:minutos:segundos.*/
        #endregion

        #region Exemplo
        /*Entrada
        O arquivo de entrada contém um valor inteiro N.

        Saída
        Imprima o tempo lido no arquivo de entrada (segundos), convertido para horas:minutos:segundos, conforme
        exemplo fornecido.
        
        556 = 0:9:16
        1 = 0:0:1*/
        #endregion

        #region Formula
        /*horas = N / 3600
         resto = N [mod] 3600
         minutos = resto / 60
         segundos = resto [mod] 60*/
        #endregion

        static void Main(string[] args)
        {
            int N, horas, resto, minutos, segundos;
            const int umaHoraEmSegundos = 3600;
            const int sessenta = 60;

            Console.Write("Entre com o valor N: ");
            N = int.Parse(Console.ReadLine());

            horas = N / umaHoraEmSegundos;
            resto = N % umaHoraEmSegundos;
            minutos = resto / sessenta;
            segundos = resto % sessenta;

            Console.WriteLine($"{horas}:{minutos}:{segundos}");

            Console.ReadKey();
        }
    }
}
