namespace Exercicio_2
{
    public class Fatura : IImprimivel
    {
        public string Devedor = "";
        public string Credor = "";
        public float Valor = 0;
        public int DiasDeAtraso = 0;
        private float Juros = 0.10f;

        
        public  Fatura(string dev, string cred, float valfat, int qtdAtraso)
        {
            Devedor = dev;
            Credor = cred;
            Valor = valfat;
            DiasDeAtraso = qtdAtraso;
        }

    public void Imprimir()
    {

        CalcularValorDivida();

        Console.WriteLine($"Credor: {Credor}");
        Console.WriteLine($"Devedor: {Devedor}");
        Console.WriteLine($"Dias de atraso: {DiasDeAtraso} dias(s)");
        Console.WriteLine($"Valor:R$ {Valor:F2}");
        Console.WriteLine($"Juros:R$ {(Juros * DiasDeAtraso):F2}");
        Console.WriteLine($"Total com juros: {Valor:F2}");
        Console.WriteLine();
    }
    
    public void CalcularValorDivida()
        {
            if (DiasDeAtraso > 0)
            {
                Valor = Valor + DiasDeAtraso * Juros;
            }

            if (DiasDeAtraso >= 5)
            {
                Console.WriteLine($"Dívida encaminhada para o SERASA");
            }
        }
    }
}