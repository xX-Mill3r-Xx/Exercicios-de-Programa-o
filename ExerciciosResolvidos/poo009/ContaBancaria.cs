using System;
using System.Globalization;

namespace poo009
{
    public class ContaBancaria
    {
        public string Titular { get; set; }
        public decimal Saldo { get; private set; }

        public void Depositar(decimal valor)
        {
            if (valor <= 0)
            {
                throw new InvalidOperationException("Valor do deposito deve ser positivo.");
            }

            Saldo += valor;
        }

        public void Sacar(decimal valor)
        {
            if (valor > Saldo)
            {
                throw new InvalidOperationException("O valor de saque não pode ser maior que o saldo.");
            }

            Saldo -= valor;
        }

        public override string ToString()
        {
            return $"Titular: {Titular} | Saldo: {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
