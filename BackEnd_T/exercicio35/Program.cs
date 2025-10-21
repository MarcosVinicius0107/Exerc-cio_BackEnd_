//Faça um programa que solicite ao usuário um número de repetições "x".Para cada
//repetição solicite dois números e imprima qual é o maior deles.
 
        int repeticoes, contador = 1;
        double n1, n2;

        Console.WriteLine("Quantas vezes você deseja repetir a comparação?");
        repeticoes = int.Parse(Console.ReadLine());

        while (contador <= repeticoes)
        {
            Console.WriteLine($"Repetição {contador}:");

            Console.Write("Digite o primeiro número: ");
            n1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            n2 = double.Parse(Console.ReadLine());

    if (n1 > n2)
    {
        Console.WriteLine($"O maior número é: {n1}");
    }
    else if (n2 > n1)
    {
        Console.WriteLine($"O maior número é: {n2}");
    }
    else
    {
        Console.WriteLine($"Os dois número são iguais: {n1}, {n2}");
    }
            contador++;
        }