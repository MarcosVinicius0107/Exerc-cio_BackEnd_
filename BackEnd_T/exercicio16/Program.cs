//Uma empresa decide dar aumento aos funcionário de acordo com o seu cargo disposto na tabela abaixo.

// Cargo                %Aumento
// Produção             6.5
// Administração        7.5
// Diretoria            12

//De acordo com a tabela acima faça um programa que receba o cargo e o salário de um funcionário
//e calcule e imprima o salário reajustado.

string cargo;
double salario;
double salarioReajustado = 0;

Console.WriteLine("*________________*");
Console.WriteLine("*Digite o cargo: *");
Console.WriteLine("*producao        *");
Console.WriteLine("*administracao   *");
Console.WriteLine("*diretoria       *");
Console.WriteLine("*________________*");

cargo = Console.ReadLine();

Console.WriteLine("Digite o salário atual:");
salario = double.Parse(Console.ReadLine());

if (cargo == "producao")
{
    salarioReajustado = salario * 1.065;
}
else if (cargo == "administracao")
{
    salarioReajustado = salario * 1.075;
}
else
{
    salarioReajustado = salario;
    Console.WriteLine("Cargo inválido, sem direito a reajuste");
 }

        Console.WriteLine($"Seu novo salário é: R$   {salarioReajustado}");
