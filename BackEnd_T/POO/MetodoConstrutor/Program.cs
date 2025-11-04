using MetodoConstrutor;

// Pessoa p1 = new Pessoa("João", 17);

//  p1.Nome = "Felipe Fontes";
//  p1.Idade = 17;

// Console.WriteLine($"O objeto pessoa que criei é o {p1.Nome} com a idade {p1.Idade}");

//  p1.Nome = "Gustavo Oliveira";

// p1.ExibirDados();

//Primeiro Construtor
Pessoa3SobreCargas PrimeiraPessoa = new Pessoa3SobreCargas();

Console.WriteLine(@$"Primeira pessoa cadastrada - Nome: {PrimeiraPessoa.Nome}, Idade: {PrimeiraPessoa.Idade}");
Console.WriteLine();

//Segundo Construtor
Pessoa3SobreCargas SegundaPessoa = new Pessoa3SobreCargas("Matheus Felix");

Console.WriteLine(@$"Primeira pessoa cadastrada - Nome: {SegundaPessoa.Nome}, Idade: {SegundaPessoa.Idade}");
Console.WriteLine();

//Terceiro Construtor
Pessoa3SobreCargas TerceiraPessoa = new Pessoa3SobreCargas("Felipe Silva,16");



Console.WriteLine(@$"Digite o nome da Terceira Pessoa");
TerceiraPessoa.Nome = Console.ReadLine();


Console.WriteLine(@$"Digite a idade da Terceira Pessoa");
TerceiraPessoa.Idade = int.Parse(Console.ReadLine());

Console.WriteLine(@$"Primeira pessoa cadastrada - Nome: {TerceiraPessoa.Nome}, Idade: {TerceiraPessoa.Idade}");