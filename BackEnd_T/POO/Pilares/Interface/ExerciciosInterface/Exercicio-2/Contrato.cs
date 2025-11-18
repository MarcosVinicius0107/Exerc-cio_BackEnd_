namespace Exercicio_2
{
    public class Contrato : IImprimivel
    {
        public string Contratante = "";
        public string PrestadorServico = "";
        public string TextoClausulas = "";

        public Contrato(string contratante, string contratada, string txtClausulas)
        {
            Contratante = contratante;
            PrestadorServico = contratada;
            TextoClausulas = txtClausulas;
        }
        public void Imprimir()
        {
            Console.WriteLine($"Contratante: {Contratante}");
            Console.WriteLine($"Contratado: {PrestadorServico}");
            Console.WriteLine($@"Cláusulas do Contrato:  
            
            {TextoClausulas}
            --
            ");

        }
    }
}