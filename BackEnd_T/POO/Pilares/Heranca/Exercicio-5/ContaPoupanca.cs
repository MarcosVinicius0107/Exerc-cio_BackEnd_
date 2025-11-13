namespace Exercicio_5
{
    public class ContaPoupanca : Conta
    {
    public void CalcularRendimento()
    {
        Saldo += Saldo * 0.02; // aumenta o saldo em 2%
    }
    
    }
}