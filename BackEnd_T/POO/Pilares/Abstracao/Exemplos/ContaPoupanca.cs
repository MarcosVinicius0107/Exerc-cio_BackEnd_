namespace Exemplos
{
    public class ContaPoupanca : ContaBancaria
    {
    public override void Sacar(double valor)
    {
        double taxa = valor * 0.005; // 0,5% de taxa sobre o valor
        double total = valor + taxa;

        if (Saldo >= total)
            Saldo -= total;
        else
            Console.WriteLine("Saldo insuficiente na conta poupança!");
    } 

    }
}