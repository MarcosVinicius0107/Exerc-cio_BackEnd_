// See https://aka.ms/new-console-template for more information

using ClassesEstaticas;
Console.WriteLine("Bem vindo ao programa");
Console.WriteLine();

Console.WriteLine($"Digite um número: ");
float a = float.Parse(Console.ReadLine());
Console.WriteLine($"Digite outro número: ");
float b = float.Parse(Console.ReadLine());

//uso da classe estática de forma auxiliar
// float r = CalculosMatematicos.Somar(a,b);
// Console.WriteLine($"Soma: {r}");

// r = CalculosMatematicos.Subtracao(a,b);
// Console.WriteLine($"Subtração: {r}");

// r = CalculosMatematicos.Multiplicacao(a,b);
// Console.WriteLine($"Multiplicação: {r}");

// r = CalculosMatematicos.Divisao(a,b);
// Console.WriteLine($"Divisão: {r}");

//Solicitar ao usuário 2 números reais e informar qual é o maior e qual é o menor dos
//números. Para isso você deve utilizar a classe Math, utilitária do C#


float Maior = Math.Max(a, b);
float Menor = Math.Min(a, b);

Console.WriteLine();
Console.WriteLine($"O maior número é: {Maior}");
Console.WriteLine($"O menor número é: {Menor}");

if (a == b)
{
    Console.WriteLine("Os dois números são iguais");
}

else
{
    Console.WriteLine($"O maior número é: {Math.Max(a, b)}");
    Console.WriteLine();
    Console.WriteLine($"O Menor número é: {Math.Min(a, b)}");
}