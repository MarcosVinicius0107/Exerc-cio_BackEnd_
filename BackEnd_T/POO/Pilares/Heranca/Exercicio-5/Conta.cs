namespace Exercicio_5
{
    public class Conta
    {
    public int Numero { get; set; }
    public double Saldo { get; protected set; }

    public void Depositar(double valor)
    {
        Saldo += valor;
    }

    public void Sacar(double valor)
    {
        if (valor <= Saldo)
        {
            Saldo -= valor;
        }
        else
        {
            Console.WriteLine("Saldo insuficiente!");
        }  
    }
    
    }
}