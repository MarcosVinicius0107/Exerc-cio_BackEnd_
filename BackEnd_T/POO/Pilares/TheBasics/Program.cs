using TheBasics;
Console.Clear();

// string[] nomes = new string[5];
// int[] idades = new int[5];
// string[] logradouros = new string[5];

//array/lista de pessoas
// List<Pessoa> people = new List<Pessoa>();


//**************Marcos**********************************
//endereco
// Endereco enderecoMarcos = new Endereco();
// enderecoMarcos.Logradouro = "Rua Niterói";

// //pessoa com endereco
// Pessoa Marcos = new Pessoa(enderecoMarcos);
// Marcos.Nome = "Marcos Vinicius";
// Marcos.Idade = 17;


//*************Julia************************************
//endereco
// Endereco enderecoJulia = new Endereco();
// enderecoJulia.Logradouro = "Rua lá de casa";

// //pessoa com endereco
// Pessoa Julia = new Pessoa(enderecoJulia);
// Julia.Nome = "Julia Borges";
// Julia.Idade = 15;


// // Console.Clear();
// Pessoa Marcos = new Pessoa();
//  Pessoa Julia = new Pessoa();
//  Pessoa Henrique = new Pessoa();
//  Pessoa Eloysa = new Pessoa();

// //preenchendo os dados das pessoas
// Marcos.Nome = "Marcos Vinicius";
// Marcos.Idade = 17;
// Marcos.Logradouro = "Rua Niterói";
// Marcos.Numero = 180;

// Marcos.Falar();

// Julia.Nome = "Julia Borges";
// Julia.Idade = 15;
// Julia.Logradouro = "Rua lá de casa";
// Julia.Numero = 543;
// Julia.Logradouro = "Apto 5 - Bloco B";

// Henrique.Nome = "Henrique do  Nascimento";
// Eloysa.Nome = "Eloysa Marques";

//guardando os dados na lista
// people.Add(Marcos);//0
// people.Add(Julia);//1
// people.Add(Henrique);//2
// people.Add(Eloysa);//3

// foreach (var p in people)
// {
//    Console.WriteLine($"Nome: {p.Nome}"); 
// }

// Console.WriteLine($"Pessoa 1: {people[0].Nome}");
// Console.WriteLine($"Pessoa 2: {people[1].Nome}");
// Console.WriteLine($"Pessoa 3: {people[2].Nome}");
// Console.WriteLine($"Pessoa 4: {people[3].Nome}");


// Endereco endEnzo = new Endereco();
// endEnzo.Logradouro = "Spínola Teixeira";
// endEnzo.Numero = 3960;
// Aluno pedroEnzo = new Aluno(endEnzo);
// pedroEnzo.Curso = "Desenvolvimento de Sistemas";
// pedroEnzo.RA = "1234-xpto";
// pedroEnzo.NotaFinal = 9.75f;

// Endereco endProfAlex = new Endereco();
// endProfAlex.Logradouro = "Rua lá de casa";
// endProfAlex.Numero = 987;

// Professor endProfAlexia = new Professor(endProfAlex);
// endProfAlexia.Nome = "Aléxia Vitória";

// Console.WriteLine($"Aluno {pedroEnzo.Nome} estuda na turma {pedroEnzo.Curso} da profa. {endProfAlexia.Nome}");


////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Carro c1 = new Carro();
// c1.Marca = "Honda";
// c1.Modelo = "Toyota";
// c1.AbrirPortaMala();

// Moto m1 = new Moto();
// m1.Marca = "BMW";
// m1.Modelo = "S1000";

// c1.Ligar();
// c1.AbrirPortaMala();

// m1.Ligar();
// m1.Empinar();

///////////////////////////////////////////////////////////////
Console.WriteLine("Espcificações do avião");
Console.WriteLine("========================");
Avião a1 = new Avião();
a1.QtdTurbinas = 2;
a1.Compainha = "GOL";
a1.QtdAssentos = 300;
a1.Modelo = "E-190";
a1.Marca = "Braer";
a1.QtdRodas = 6;

Console.WriteLine($"Quantidade de assentos: {a1.QtdAssentos}");
Console.WriteLine($"Compainha: {a1.Compainha}");
Console.WriteLine($"Modelo: {a1.QtdTurbinas}");
Console.WriteLine($"Marca: {a1.QtdTurbinas}");
Console.WriteLine($"Quantidade de turbina: {a1.QtdTurbinas}");
Console.WriteLine($"Quantidade de rodas: {a1.QtdRodas}");
a1.Decolar();
a1.Pousar();