namespace ExerciciosMetodoConstrutor
{
    public class Produto
    {

        public string Nome;
        public double Preco;
        public int Estoque;

        public Produto(string nome, double preco, int estoque)
        {
            Nome = nome;
            Preco = preco;
            Estoque = estoque;
        }

        public void MostrarDados()
        {
            Console.WriteLine("=== Dados do Produto ===");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Preço: R$ {Preco}");
            Console.WriteLine($"Estoque: {Estoque} unidades");
        }
    }
}