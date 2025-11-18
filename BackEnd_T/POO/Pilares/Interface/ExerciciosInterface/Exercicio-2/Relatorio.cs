namespace Exercicio_2
{
    public class Relatorio : IImprimivel
    {
        public string Nome = "";
        public string Textorelatorio = "";
    
        //Sobrecarga de construtor
        public Relatorio(string responsavel, string txtRelatorio)
        {
            Nome = responsavel;
            Textorelatorio = txtRelatorio;
        }
        public void Imprimir()
        {
            Console.WriteLine($"Responsável: {Nome}...");
            Console.WriteLine(Textorelatorio);
            Console.WriteLine($"--");
        }
    }
}