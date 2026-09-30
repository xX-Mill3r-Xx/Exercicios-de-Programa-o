using poo016.Entities;
using poo016.Enuns;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace poo016
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter departament's name: ");
            string department = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Enter Worker data: ");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Level: (Junior/ MidLevel/Senior): ");
            WorkerLever level = (WorkerLever)Enum.Parse(typeof(WorkerLever), Console.ReadLine());

            Console.Write("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Worker worker = new Worker(name, level, baseSalary, new Departament(department));
            
            Console.WriteLine();
            Console.Write("How many contracts to this worker? ");
            int contractWorker = int.Parse(Console.ReadLine());

            for (int i = 0; i < contractWorker; i++)
            {
                Console.WriteLine($"Enter #{i + 1} contract data: ");
                Console.Write("Date: (DD/MM/YYYY): ");
                DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                Console.Write("Value per hours: ");
                double valuePerHours = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (Hours): ");
                int hours = int.Parse(Console.ReadLine());

                worker.AddContract(new HourContract(date, valuePerHours, hours));
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string[] parts = Console.ReadLine().Split('/');
            int month = int.Parse(parts[0]);
            int year = int.Parse(parts[1]);

            Console.WriteLine($"Name: {worker.Name}");
            Console.WriteLine($"Department: {worker.Departament.Name}");
            Console.WriteLine($"Income for {month.ToString("00")}/{year}: {worker.Income(year, month).ToString("F2",CultureInfo.InvariantCulture)}");
        }
    }
}
