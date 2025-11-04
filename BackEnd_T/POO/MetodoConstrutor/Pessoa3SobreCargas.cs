namespace MetodoConstrutor
{
    public class Pessoa3SobreCargas
    {
        public string Nome = "";
        public int Idade;

        public Pessoa3SobreCargas()
        {
            Nome = "Desconhecido";
            Idade = 0;
        }

        public Pessoa3SobreCargas(string n)
        {
            Nome = n;
            Idade = 0;
        }

        public Pessoa3SobreCargas(string n, int i)
        {
            Nome = n;// inicializa com o valor de n
            Idade = i;// inicializa com o valor de i
        }
        
        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }
    }
}