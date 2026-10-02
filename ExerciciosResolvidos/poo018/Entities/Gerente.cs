namespace poo018.Entities
{
    public class Gerente : Funcionario
    {
        public decimal Bonus { get; set; }

        public Gerente()
        {

        }

        public Gerente(string nome, decimal salarioBase, decimal bonus) : base(nome, salarioBase)
        {
            Bonus = bonus;
        }

        public override decimal CalculaSalario()
        {
            return SalarioBase + Bonus;
        }
    }
}
