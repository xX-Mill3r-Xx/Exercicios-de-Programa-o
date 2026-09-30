namespace poo014
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Salario { get; private set; }

        public Funcionario()
        {
                
        }

        public Funcionario(int id, string nome, decimal salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void AumentoSalarial(decimal porcentagem)
        {
            decimal aumento = Salario * porcentagem / 100M;
            Salario += aumento;
        }
    }
}
