using poo016.Enuns;
using System.Collections.Generic;

namespace poo016.Entities
{
    public class Worker
    {
        public string Name { get; set; }
        public WorkerLever Level { get; set; }
        public double BaseSalary { get; set; }
        public Departament Departament { get; set; }
        public List<HourContract> Contracts { get; private set; } = new List<HourContract>();

        public Worker()
        {

        }

        public Worker(string name, WorkerLever level, double baseSalary, Departament departament)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departament = departament;
        }

        public void AddContract(HourContract contract)
        {
            this.Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            this.Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                    sum += contract.TotalValue();
            }
            return sum;
        }
    }
}
