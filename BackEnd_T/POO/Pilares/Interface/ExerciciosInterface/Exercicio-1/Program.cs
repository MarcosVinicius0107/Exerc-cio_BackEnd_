//Exercício 1
/*Crie uma interface chamada IForma com o método Calculadora.
Crie duas classes que implementem essa interface: Retangulo e Circulo.
No programa, peça os valores necessários e exiba a área calculada para cada forma.

No Retangulo utilizar o cálculo = Largura * Altura;
No Círculo utilizar o cálculo = PI * Raio * Raio;

Extra Pesquisar sobre a classe Mth do C# e utilizar a constante PI - Math.PI*/

using Exercicio_1;
Console.Clear();

 // Retângulo
Console.Write("Digite a largura do retângulo: ");
float l = float.Parse(Console.ReadLine());

Console.Write("Digite a altura do retângulo: ");
float a = float.Parse(Console.ReadLine());

Retangulo r = new Retangulo();
r.Largura = l;
r.Altura = a;
r.Calculadora();
Console.WriteLine();


Console.WriteLine($"Agora vamos calcular a área do circulo");


// Círculo
Console.Write("Digite o raio do círculo: ");
float r1 = float.Parse(Console.ReadLine());

Circulo c = new Circulo();
c.Raio = r1;
c.Calculadora();
Console.WriteLine();

Console.Write("Fim do programa :)! ");
Console.WriteLine();