//1.Classe Animal
//Crie uma classe abstrata chamada Animal com os métodos FazerSom() e Mover().
//Crie duas classes derivadas: Cachorro e Gato. Cada uma deve implementar os
//métodos de forma diferente.

using Exemplos;

// Cachorro toto = new Cachorro();
// toto.FazerSom();
// toto.Mover();

// Gato chaninho = new Gato();
// chaninho.FazerSom();
// chaninho.Mover();

// Pessoa p1 = new Pessoa();
// p1.FazerSom();
// p1.Mover(); 


//2.Classe ContaBancaria
//Crie uma classe abstrata ContaBancaria com os métodos Depositar(double valor)
//e Sacar(double valor).Crie duas classes: ContaCorrente e ContaPoupanca, cada
//uma com sua forma de calcular o saldo após saque (por exemplo, tava diferente).

Console.Clear();
ContaCorrente cc = new ContaCorrente();
ContaPoupanca cp = new ContaPoupanca();

cc.Depositar(10);
cp.Depositar(10);

cc.Sacar(10);
cp.Sacar(5);

Console.WriteLine($"Saldo Conta Corrente: {cc.Saldo }");
Console.WriteLine($"Saldo Conta Poupança: {cp.Saldo}");