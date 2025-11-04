namespace MetodoConstrutor
{
    public class Pessoa
    {
        public string Nome = "";
        public int Idade;

        // método Construtor de Pessoa, possui parametros
        /*Parametros represetam valores para as suas respectivas
         props ou seja seja, estamos inicializando valores para 
         as props nome e*/
        public Pessoa(string n, int i)
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