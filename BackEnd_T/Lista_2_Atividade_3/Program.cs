//Escreva     um     programa que leia     as     medidas     dos     lados     de     um     triângulo
//      e    escreva    se    ele    é    Equilátero,    Isósceles    ou    Escaleno.    Sendo    que:     
/*
   − Triângulo    Equilátero:    possui    os    3    lados    iguais.     
   − Triângulo    Isóscele:    possui    2    lados    iguais.     
   − Triângulo    Escaleno:    possui    3    lados    diferentes.
*/

double lado1, lado2, lado3;

        Console.Write("Digite o valor do primeiro lado: ");
        lado1 = double.Parse(Console.ReadLine());

        Console.Write("Digite o valor do segundo lado: ");
        lado2 = double.Parse(Console.ReadLine());

        Console.Write("Digite o valor do terceiro lado: ");
        lado3 = double.Parse(Console.ReadLine());


if (lado1 < lado2 + lado3 && lado2 < lado1 + lado3 && lado3 < lado1 + lado2)
{

    if (lado1 == lado2 && lado2 == lado3)
    {
        Console.WriteLine("Triângulo Equilátero: possui os 3 lados iguais.");
    }
    else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
    {
        Console.WriteLine("Triângulo Isósceles: possui 2 lados iguais.");
    }
    else
    {
        Console.WriteLine("Triângulo Escaleno: possui 3 lados diferentes.");
    }
}
else
{
    Console.WriteLine("Os valores informados não formam um triângulo válido.");
}
        
 // obs: Foi pesquisado no gpt para ter um apoio para a conclusão do código pois eu não me recordava
 // dos símbolos de programação.