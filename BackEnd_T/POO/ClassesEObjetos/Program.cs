 //imports das class externas
 using ClassesEObjetos;


// Console.Write("Digite seu nome: ");
// string nome = Console.ReadLine();

// Garrafa g1 = new Garrafa();

// Console.Write("Digite a capacidade da garrafa (em mililitros): ");
// g1.capacidade = double.Parse(Console.ReadLine());

// Console.Write("Digite a marca da garrafa: ");
// g1.marca = Console.ReadLine();

// Console.Write("Digite o modelo da garrafa: ");
// g1.modelo = Console.ReadLine();

// Console.Write("Digite a cor da garrafa: ");
// g1.cor = Console.ReadLine();
// Console.WriteLine();

// g1.Abrir();
// g1.Encher();
// g1.Esvaziar();
// g1.Fechar();

// Console.WriteLine();
// Console.WriteLine($"--- Garrafa do {nome} ---");
// Console.WriteLine();
// Console.WriteLine($"Marca: {g1.marca}");
// Console.WriteLine($"Modelo: {g1.modelo}");
// Console.WriteLine($"Cor: {g1.cor}");
// Console.WriteLine($"Capacidade: {g1.capacidade} ml");
// Console.WriteLine();   

//////////////////////////////////////////////////////////////////////////////////

// AgenciaBancaria conta = new AgenciaBancaria();

// Console.WriteLine($"--- Agência Bancária ---");
// Console.Write("Digite o nome do titular da conta: ");
// conta.titular = Console.ReadLine();

// // Define o saldo inicial
// Console.Write("Digite o saldo inicial da conta: ");
// conta.saldo = double.Parse(Console.ReadLine());

// Console.WriteLine();
// Console.WriteLine($"Conta criada com sucesso para {conta.titular}!:)");
// Console.WriteLine($"Saldo inicial: R${conta.saldo:F2}");
// Console.WriteLine();

// // Realiza depósito
// Console.Write("Digite o valor que deseja depositar: ");
// double valorDeposito = double.Parse(Console.ReadLine());
// conta.Depositar(valorDeposito);

// // Realiza saque
// Console.Write("Digite o valor que deseja sacar: ");
// double valorSaque = double.Parse(Console.ReadLine());
// conta.Sacar(valorSaque);

// // Exibe o saldo final
// Console.WriteLine($"Saldo final da conta de {conta.titular}: R${conta.saldo:F2}");

/////////////////////////////////////////////////////////////////////////////////////////////

// Pessoa joao = new Pessoa();

// joao.Nome = "João Silva";
// Console.WriteLine($"{joao.Nome} tem {joao.Idade} anos");

// joao.Envelhecer(17);
// Console.WriteLine($"{joao.Nome} tem {joao.Idade} anos");

// int novaIdade = joao.Envelhecer(17);//atualizaa idade e devolve a idade
// Console.WriteLine($"{joao.Nome} tem {joao.Idade} anos");

// joao.Envelhecer(-50);//devolve a idade antiga: 17
// Console.WriteLine($"{joao.Nome} tem {joao.Idade} anos");

////////////////////////////////////////////////////////////////////////////////////////////////

// Criação do objeto Produto
Produto produto = new Produto();

// Pede informações ao usuário
Console.Write("Digite o nome do produto: ");
produto.nome = Console.ReadLine();

Console.Write("Digite o preço do produto: ");
produto.preco = double.Parse(Console.ReadLine());

Console.Write("Digite o percentual de desconto (%): ");
double percentual = double.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine($"Produto: {produto.nome}");
Console.WriteLine($"Preço original: R${produto.preco:F2}");
Console.WriteLine();

// Aplica o desconto
produto.AplicarDesconto(percentual);

// Mostra o preço final
Console.WriteLine($"Preço final do produto {produto.nome}: R${produto.preco:F2}");
