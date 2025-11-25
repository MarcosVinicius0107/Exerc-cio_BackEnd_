using Encapsulamento;

// float dinheiro =200;

// ContaBancaria contaEdu = new ContaBancaria();
// ContaBancaria contaMaria = new ContaBancaria(dinheiro);

// contaEdu.Depositar(dinheiro);
// contaEdu.Sacar(30);
// contaMaria.Sacar(50);
// Console.WriteLine();

// Console.WriteLine($"Saldo atualizado da conta: R$:{contaEdu.GetSaldo()}");
// Console.WriteLine($"Saldo da conta de Maria: R$:{contaMaria.GetSaldo()}");


Carro meuCarro = new Carro();

meuCarro.DefinirMarca("Toyota");
meuCarro.DefinirModelo("Corolla");

meuCarro.Acelerar(50);
meuCarro.Frear(30); // aqui deve zerar a velocidade

Console.WriteLine("Marca: " + meuCarro.ObterMarca());
Console.WriteLine("Modelo: " + meuCarro.ObterModelo());
Console.WriteLine("Velocidade Atual: " + meuCarro.ObterVelocidade() + " km/h");