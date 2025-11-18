namespace Exemplos
{
    public class ContaCorrente : ContaBancaria
    {
           public override void Sacar(double valor)
    {
        double taxa = 1.0;
        double total = valor + taxa;

        if (Saldo >= total)
            Saldo -= total;
        else
            Console.WriteLine("Saldo insuficiente na conta corrente!"); 
    }
    }
}