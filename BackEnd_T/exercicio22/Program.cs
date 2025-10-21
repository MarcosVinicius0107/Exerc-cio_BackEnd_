//Faça um programa que imprima que imprima os números ímpares de 0 a 50;

 Console.WriteLine("Números ímpares de 0 a 50:");

     for (int contador = 1; contador <= 50; contador += 2)
{
    if(contador % 2 == 1)

    {
        Console.WriteLine($"Contando em numero impares: {contador}");
    }
    
}