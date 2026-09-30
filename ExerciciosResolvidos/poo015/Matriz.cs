namespace poo015
{
    public class Matriz
    {
        public int[,] MatrizInteiros { get; set; }
        public decimal[,] MatrizDecimal { get; set; }
        public double[,] MatrizDouble { get; set; }
        public string[,] MatrizString { get; set; }

        public Matriz(int[,] matrizInteiros)
        {
            MatrizInteiros = matrizInteiros;
        }
    }
}
