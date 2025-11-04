namespace ExerciciosMetodoConstrutor
{
    public class ContaBancaria
    {
        public string Titular;
        public double Saldo;

        public ContaBancaria(string titular, double saldoInicial)
        {
            Titular = titular;
            Saldo = saldoInicial;
        }

        public ContaBancaria(string titular)
        {
            Titular = titular;
            Saldo = 0.0;
        }

        public void MostrarDados()
        {
            Console.WriteLine("=== Dados da Conta Bancária ===");
            Console.WriteLine($"Titular: {Titular}");
            Console.WriteLine($"Saldo: R$ {Saldo:F2}");
        }
    }
}