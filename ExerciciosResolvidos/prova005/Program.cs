using System;

namespace prova005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Enunciado
            /*Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha 
            incorreta informada, escrever a mensagem "Senha Invalida". Quando a senha for informada corretamente deve ser 
            impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002.*/
            #endregion

            int senha;
            const int senhaCorreta = 2002;

            Console.Write("Entre com sua senha: ");
            senha = int.Parse(Console.ReadLine());

            if (senha != senhaCorreta)
                Console.WriteLine("Senha Invalida");
            else
                Console.WriteLine("Acesso Permitido");

            while (senha != senhaCorreta)
            {
                Console.Write("Entre com sua senha: ");
                senha = int.Parse(Console.ReadLine());

                if (senha != senhaCorreta)
                    Console.WriteLine("Senha Invalida");
                else
                    Console.WriteLine("Acesso Permitido");
            }
        }
    }
}
