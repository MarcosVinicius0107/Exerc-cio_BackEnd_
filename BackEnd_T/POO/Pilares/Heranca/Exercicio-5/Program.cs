using Exercicio_5;

ContaPoupanca cp = new ContaPoupanca();
cp.Numero = 12345;

cp.Depositar(1000); // deposita R$1000
Console.WriteLine($"Saldo antes do rendimento: R${cp.Saldo:F2}");

cp.CalcularRendimento(); // aplica o rendimento de 2%
Console.WriteLine($"Saldo após o rendimento: R${cp.Saldo:F2}");
