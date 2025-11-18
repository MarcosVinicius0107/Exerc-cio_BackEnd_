namespace Exemplos
{
    public abstract class ContaBancaria
    {
    public double Saldo { get; protected set; }

    public void Depositar(double valor)
    {
        Saldo += valor;
    }

    
    public abstract void Sacar(double valor);
    }
}