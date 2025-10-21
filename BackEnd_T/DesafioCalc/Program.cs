int n1;
int n2;

//pedir os dois números
Console.WriteLine("Digite o primeiro número");
n1 = int.Parse(Console.ReadLine());//converte o texto em número
Console.WriteLine("Digite o segundo número");
n2 = int.Parse(Console.ReadLine());//converte o texto em número
if (n1 > n2)
{
    Console.WriteLine("O primeiro número é o maior: " + (n1));
}
else if (n1 < n2)
{
    Console.WriteLine("O segundo número é o maior " + (n2));
}
else if (n1 == n2)
{
    Console.WriteLine("Os dois númros são iguais");
}