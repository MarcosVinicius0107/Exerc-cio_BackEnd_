namespace ClassesEObjetos
{
    public class AgenciaBancaria
    {
        // Atributos
        public string titular = "";
        public double saldo;

        // Método para depositar dinheiro
        public void Depositar(double valor)
        {
            saldo += valor;
            Console.WriteLine($"Depósito de R${valor:F2} realizado com sucesso!");
            Console.WriteLine($"Saldo atual: R${saldo:F2}");
            Console.WriteLine();
        }

        // Método para sacar dinheiro
        public void Sacar(double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
                Console.WriteLine($"Saque de R${valor:F2} realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para realizar o saque!");
            }
            Console.WriteLine($"Saldo atual: R${saldo:F2}");
            Console.WriteLine();
        }
    }
}
