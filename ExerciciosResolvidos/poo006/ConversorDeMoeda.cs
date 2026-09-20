namespace poo006
{
    public static class ConversorDeMoeda
    {
        public static decimal IOF = 6.0m;

        public static decimal Converter(decimal quantia, decimal cotacao)
        {
            decimal total = quantia * cotacao;
            return total + total * IOF / 100.0m;
        }
    }
}
