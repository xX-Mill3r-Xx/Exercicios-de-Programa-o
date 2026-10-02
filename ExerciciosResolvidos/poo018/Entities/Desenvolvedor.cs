namespace poo018.Entities
{
    public class Desenvolvedor : Funcionario
    {
        public int HorasExtras { get; set; }
        public decimal ValorHoraExtra { get; set; }

        public Desenvolvedor()
        {

        }

        public Desenvolvedor(string nome, decimal salarioBase, int horasExtras, decimal valorHoraExtra) : base(nome, salarioBase)
        {
            HorasExtras = horasExtras;
            ValorHoraExtra = valorHoraExtra;
        }

        public override decimal CalculaSalario()
        {
            return SalarioBase + (HorasExtras * ValorHoraExtra);
        }
    }
}
