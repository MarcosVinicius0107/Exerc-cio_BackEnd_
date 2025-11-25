using System.Dynamic;

namespace Encapsulamento
{
    public class ContaBancaria
    {
       private float Saldo;

       //Construtor
       public ContaBancaria()
        {
            Saldo = 0;
        } 

        public ContaBancaria(float saldoInicial)
        {
            if (saldoInicial > 0)
            {
                Saldo = saldoInicial;
            }
        }

        //Método público que seta/configura/guarda o valor
        public void Depositar( float valor)
        {
            if (valor >= 0)
            {
                Saldo = valor;
                return;
            }

        Console.WriteLine($"Valor para depósito inválido!");
        }

        //Método públic que retorna o saldo
        public float GetSaldo()
        {
            return Saldo;
        }

        // crie o metódo público Sacar(float valor)
        public void Sacar(float valor)
        {
            if (valor <= Saldo)
            {
                Console.WriteLine($"Saque realizado com sucesso");
            }
            else
            {
                Console.WriteLine($"Saque inválido");
            }
            Saldo -= valor;
        }
    }
}