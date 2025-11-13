using Exercicio_2;

Funcionario f1 = new Funcionario("Marcos", 3000);
Console.WriteLine($"Funcionário: {f1.Nome} - Salário: R${f1.CalcularSalario()}");

Gerente g1 = new Gerente("Julia", 5000, 2000);
Console.WriteLine($"Gerente: {g1.Nome} - Salário: R${g1.CalcularSalario()}");

