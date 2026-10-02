using poo018.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace poo018
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Funcionário:");
            Console.Write("Nome: ");
            string funcionario = Console.ReadLine();
            Console.Write("Salário Base: ");
            decimal salarioFuncionario = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Funcionario funcionarioPadrao = new Funcionario();
            funcionarioPadrao.Nome = funcionario;
            funcionarioPadrao.SalarioBase = salarioFuncionario;
            Console.WriteLine();

            Console.WriteLine("Gerente:");
            Console.Write("Nome: ");
            string gerente = Console.ReadLine();
            Console.Write("Salário Base: ");
            decimal salarioGerente = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Bonus: ");
            decimal bonusGerente = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Gerente gerentePadrao = new Gerente();
            gerentePadrao.Nome = gerente;
            gerentePadrao.SalarioBase = salarioGerente;
            gerentePadrao.Bonus = bonusGerente;
            Console.WriteLine();

            Console.WriteLine("Desenvolvedor:");
            Console.Write("Nome: ");
            string desenvolvedor = Console.ReadLine();
            Console.Write("Salário Base: ");
            decimal salarioDesenvolvedor = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Horas Extras: ");
            int horaExtraDev = int.Parse(Console.ReadLine());
            Console.Write("Valor Hora Extra: ");
            decimal valorHoraDev = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Desenvolvedor dev = new Desenvolvedor();
            dev.Nome = desenvolvedor;
            dev.SalarioBase = salarioDesenvolvedor;
            dev.HorasExtras = horaExtraDev;
            dev.ValorHoraExtra = valorHoraDev;

            List<Funcionario> funcionarios = new List<Funcionario>
            {
                funcionarioPadrao,
                gerentePadrao,
                dev
            };

            Console.WriteLine();
            foreach (var f in funcionarios)
            {
                Console.WriteLine($"{f.Nome} - Salário final: R$ {f.CalculaSalario().ToString("F3", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
