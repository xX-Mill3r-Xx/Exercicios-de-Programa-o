using poo017.Entities;
using System;

namespace poo017
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(1001, "Alex", 500.0);
            Account account1 = new SavingsAccount(1002, "Anna", 500.0, 0.01);

            account.WithDraw(10.0);
            account1.WithDraw(10.0);

            Console.WriteLine(account.Balance);
            Console.WriteLine(account1.Balance);
        }
    }
}
