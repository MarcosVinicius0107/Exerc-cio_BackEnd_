/*
Exercício 2
Crie uma interface chamada IImprimivel com um método Imprimir.
Implemente essa interface nas classes Relatorio, Contrato e Fatura.
Em um programa principal, crie uma lista de objetos e chame o método Imprimir para cada item da lista.
*/
// Console.WriteLine("===CONTRATO===");
// Contrato ct = new Contrato();
// ct.Nome = "Marcos Vinicius";
// ct.Idade = 24;
// ct.Endereco = "Viela Dom Pedro Número - 2B";
// ct.Imprimir();

// Console.WriteLine();

// Console.WriteLine("===RELATÓRIO===");
// Relatorio rl = new Relatorio();
// rl.Imprimir();

// Console.WriteLine();

// Console.WriteLine("===FATURA===");
// Fatura ft = new Fatura();
// ft.Imprimir();
// Console.WriteLine();
// Fatura fatEdu = new Fatura($"Eduardo", "Izabel Dark Lab", 50, 1);
// fatEdu.Imprimir();

using Exercicio_2;
List<IImprimivel> documentos = new List<IImprimivel>();

int opcao;
do
{
Console.Clear();
//Cria um menu da seguinte forma:
Console.WriteLine($"Menu de Opções");
Console.WriteLine(@$"
1)Cadastrar Fatura
2)Cadastrar Relatório
3)Cadastrar Contrato
4)Listar Faturas
5)Listar Relatórios
6)Listar Contratos
0)Sair
Escolha a Opção:");
opcao = int.Parse(Console.ReadLine());

switch (opcao)
{
    case 1:
    CadastrarFatura();
    break;

    case 2:
    CadastrarRelatorio();
    break;

    case 3:
    CadastrarContrato();
    break;

    case 4:
    ListarFaturas();
    break;

    case 5:
    ListarRelatorio();
    break;

    case 6:
    ListarContratos();
    break;

    default:
    Console.WriteLine($"opção inválida!");
    break;
}

Console.WriteLine($"Digite <Enter> para continuar");
Console.ReadLine();//Para o console dar um tempo de ver as mensagens do programa

}while (opcao != 0);

void CadastrarFatura()
{
    Console.WriteLine($"Digite o nome do devedor:");
    string dev = Console.ReadLine();

    Console.WriteLine($"Digite o nome do credor");
    string cred = Console.ReadLine();

    Console.WriteLine($"Digite o valor da fatura");
    float valor = float.Parse (Console.ReadLine());

    Console.WriteLine($"Quantos dias a fatura está em atraso?");
    int diasAtraso = int.Parse(Console.ReadLine());

    //Cria o objeto da fatura
    Fatura f = new Fatura(dev, cred, valor, diasAtraso);
    //cadastra a fatura na lista
    documentos.Add(f);
}

void CadastrarContrato()
{
    Console.WriteLine($"Digite o nome do Contratante:");
    string contratante = Console.ReadLine();

    Console.WriteLine($"Digite o nome da pessoa contratada:");
    string contratada = Console.ReadLine();

    Console.WriteLine($"Digite a Clausula:");
    string txtClausulas = Console.ReadLine();

    Contrato c = new Contrato(contratante, contratada, txtClausulas);
    documentos.Add(c);
}

void CadastrarRelatorio()
{
    Console.WriteLine($"Digite o Nome:");
    string responsavel = Console.ReadLine();

    Console.WriteLine($"Digite o Relatório:");
    string txtRelatorio = Console.ReadLine();

    Relatorio r = new Relatorio(responsavel, txtRelatorio);
    documentos.Add(r);
}

void ListarFaturas()
{
        Console.WriteLine("=== LISTA DE FATURAS ===");

    foreach (var item in documentos)
    {
        if (item is Fatura f)
        {
            f.Imprimir();
        }
    }

}

void ListarContratos()
{
        Console.WriteLine("=== LISTA DE CONTRATOS ===");

    foreach (var item in documentos)
    {
        if (item is Contrato c)
        {
            c.Imprimir();
        }
    }
}

void ListarRelatorio()
{
        Console.WriteLine("=== LISTA DE RELATÓRIOS ===");

    foreach (var item in documentos)
    {
        if (item is Relatorio r)
        {
            r.Imprimir();
        }
    }
}