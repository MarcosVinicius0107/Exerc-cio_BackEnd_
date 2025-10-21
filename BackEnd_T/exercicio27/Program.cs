//Faça um programa que pergunte para o usuário a quantidade de números que ele
//quer digitar. Após isso crie um laço que exiba o número que o usuário digitar apenas
//se for PAR.Utilize a estrutura WHILE.

// Perguntar quantos números o usuário quer digitar
//Criar um laço while baseado na quantidade de números que o usuário quer digitar
//dentro do laço, verificar se é par e imprmir $"Número digitado é par: {nDigitado}"

        int quantidade, contador = 1, nDigitado;

        Console.WriteLine("Quantos números você deseja digitar?");
        quantidade = int.Parse(Console.ReadLine());

        while (contador <= quantidade)
        {
            Console.WriteLine($"Digite o {contador}º número:");
            nDigitado = int.Parse(Console.ReadLine());

    if (nDigitado % 2 == 0)
    {
        Console.WriteLine($"Número digitado é par: {nDigitado}");

    }
            contador++;
        }
