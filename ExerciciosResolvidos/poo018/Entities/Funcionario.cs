namespace poo018.Entities
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public decimal SalarioBase { get; set; }

        public Funcionario()
        {

        }

        public Funcionario(string nome, decimal salarioBase)
        {
            Nome = nome;
            SalarioBase = salarioBase;
        }

        public virtual decimal CalculaSalario()
        {
            return SalarioBase;
        }
    }
}
