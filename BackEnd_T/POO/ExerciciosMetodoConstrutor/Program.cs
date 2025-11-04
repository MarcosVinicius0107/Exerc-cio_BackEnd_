using ExerciciosMetodoConstrutor;

//Carro c1 = new Carro("Chevrolet", "Camaro", 2022);
//c1.ExibirDados();
//Console.WriteLine();

//////////////////////////////////////////////////////////////////////////////////////

// Aluno PrimeiroAluno = new Aluno();

// System.Console.WriteLine(@$"Primeiro Aluno:
//                              Nome: {PrimeiroAluno.Nome}
//                              Nota: {PrimeiroAluno.Nota}

// "); 

// Aluno SegundoAluno = new Aluno();

// System.Console.WriteLine("Digite o nome do Segundo Aluno");
// SegundoAluno.Nome = Console.ReadLine();

// System.Console.WriteLine("Digite a nota do Segundo Aluno");
// SegundoAluno.Nota = double.Parse (Console.ReadLine());



// System.Console.WriteLine(@$"Segundo Aluno:
//                              Nome: {SegundoAluno.Nome}
//                              Nota: {SegundoAluno.Nota}

// "); 

//////////////////////////////////////////////////////////////////////////

// Produto p1 = new Produto("Notebook", 3500.00, 10);
// {
//         p1.MostrarDados();
// }

//////////////////////////////////////////////////////////////////////////

//  ContaBancaria conta1 = new ContaBancaria("Marcos", 500.00);
//         conta1.MostrarDados();

//         Console.WriteLine();

//         ContaBancaria conta2 = new ContaBancaria("Julia");
//         conta2.MostrarDados();

///////////////////////////////////////////////////////////////////////

MediaAluno a1 = new MediaAluno(6, 7, 2);

a1.Nome = "Lucas";
a1.Media();

MediaAluno a2 = new MediaAluno();

a2.Nome = "Samuel";
a2.Media();
