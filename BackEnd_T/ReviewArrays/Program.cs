String nome = "Eduardo";

Console.WriteLine($"Nome: {nome}");
//cria um array tamanho 4 e preenche com vazio
string[] nomes = new string[4];//tamanho é 4 - de 0 a 3

nomes[0] = "Maria";
nomes[1] = "Matheus";
nomes[2] = "Eloysa";
nomes[3] = "Felipe";

Console.WriteLine();

for (int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine(nomes[i]);
}
/*
Console.WriteLine(nomes[0]);
Console.WriteLine(nomes[1]);
Console.WriteLine(nomes[3]);
Console.WriteLine(nomes[4]);//não existe*/


