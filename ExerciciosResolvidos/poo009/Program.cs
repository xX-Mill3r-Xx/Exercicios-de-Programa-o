using System;
using System.Globalization;

namespace poo009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Enunciado
            /*Crie uma classe ContaBancaria com:

            Propriedades Titular (string) e Saldo (decimal, somente leitura externa — private set)

            Métodos Depositar(decimal valor) e Sacar(decimal valor)

            Regras:

            Não permitir depósito ou saque de valor ≤ 0

            Não permitir saque maior que o saldo

            Exibir mensagem de sucesso ou erro em cada operação

            Propriedade calculada Resumo que retorna: "Titular: X | Saldo: R$ Y"

            Desafio: tente impedir que o Saldo seja alterado diretamente de fora da classe.*/
            #endregion

            Console.Write("Entre com o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Entre com um valor para deposito inicial: ");
            decimal valor = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            ContaBancaria conta = new ContaBancaria { Titular = titular };

            conta.Depositar(valor);
            Console.WriteLine($"Deposito inicial de {valor.ToString("F2", CultureInfo.InvariantCulture)} realizado com sucesso!");
            Console.WriteLine(conta.ToString());

            Console.Write("Entre com um valor para saque: ");
            valor = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            conta.Sacar(valor);
            Console.WriteLine($"Saque de {valor.ToString("F2", CultureInfo.InvariantCulture)} realizado com sucesso!");
            Console.WriteLine(conta.ToString());
        }
    }
}
