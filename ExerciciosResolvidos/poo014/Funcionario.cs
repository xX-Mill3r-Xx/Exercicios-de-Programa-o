namespace poo014
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Salario { get; private set; }

        public decimal AlmentoSalarial(decimal porcentagem)
        {
            porcentagem = Salario * 100 / 2.0M;
            return porcentagem;
        }
    }
}
