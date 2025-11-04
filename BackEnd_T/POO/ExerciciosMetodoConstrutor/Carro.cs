namespace ExerciciosMetodoConstrutor
{
    public class Carro
    {
        public string Marca = "";
        public string Modelo = "";
        public int Ano;

        public Carro(string Ma, string Mo, int A)
        {
            Marca = Ma;
            Modelo = Mo;
            Ano = A;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Carro: {Marca} {Modelo}, Ano: {Ano}");
        }

    }
}