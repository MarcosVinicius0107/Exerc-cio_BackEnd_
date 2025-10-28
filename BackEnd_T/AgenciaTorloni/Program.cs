// criar um  menu da seguindo forma  em loop que chame as funções
//1.Cadastrar Cliente
//2.Depositar
//3.Sacar
//4.Transferir
//5.Listar Clientes
//0.Sair

//por enquanto, as funções apenas devem exibir  uma mensagem  "Funções em Desenvolvimento"

//Criação de Varíaveis
string[] nomes = new string[10];//tamanho é 10 - de 0 a 9
double[] saldos = new double[10];
int opcao = -1, totalClientes = 0;


do
{
    Console.Clear();
    Console.WriteLine($"******************AGÊNCIA BANCÁRIA**********************");
    Console.WriteLine($"[                                                      ]");
    Console.WriteLine($"[         Seja Bem Vindo, no que posso ajudar!         ]");
    Console.WriteLine($"[                                                      ]");
    Console.WriteLine($"[1)Cadastrar Cliente                                   ]");
    Console.WriteLine($"[2)Depositar                                           ]");
    Console.WriteLine($"[3)Sacar                                               ]");
    Console.WriteLine($"[4)Transferir                                          ]");
    Console.WriteLine($"[5)Listar clientes                                     ]");
    Console.WriteLine($"[0)Sair                                                ]");
    Console.WriteLine($"[                                                      ]");
    Console.WriteLine($"[Escolha uma opção                                     ]");
    Console.WriteLine($"********************************************************");
    opcao = int.Parse(Console.ReadLine());

    //chamar a função correta
    switch (opcao)
    {
        case 0:
            Console.WriteLine($"SAINDO ...");
            break;

        case 1:
            CadastrarCliente();
            break;

        case 2:
            Depositar();
            break;

        case 3:
            Sacar();
            break;

        case 4:
            Transferir();
            break;

        case 5:
            ListarClientes();
            break;

        default:
            Console.WriteLine($"opção Inválida!");
            break;
    }

    Console.WriteLine($"Pressione <ENTER> para continuar ...");
    Console.ReadLine();

} while (opcao != 0);


//=====================Funções=========================

void CadastrarCliente()
{
    //verificar se tem espaço no array para se cadastrar
if (totalClientes >= 3)
    {//não pode mais cadastrar
        Console.WriteLine($"Limite de ocupação atingido");
        return;
    }

    Console.WriteLine($"Nome do Cliente: ");
    nomes[totalClientes] = Console.ReadLine();//guarda o nome no array
    saldos[totalClientes] = 0;
    totalClientes++;
    Console.WriteLine($"cliente cadastrado com sucesso");

}

void Depositar()
{
    int idCliente = buscarCliente();
    if (idCliente == -1)
    {
        return;
    }
    Console.WriteLine($"Valor para depósito: ");
    double valorDeposito = double.Parse(Console.ReadLine());
    saldos[idCliente] += valorDeposito;
    Console.WriteLine($"Depósito de R$ {valorDeposito} realizado");

}

void Sacar()
{
    //BUSCAR O CLIENTE  
    int idCliente = BuscarCliente();
    if (idCliente == -1)
    {
        return;
    }

    //PEDIR O VALOR DE SAQUE
    System.Console.WriteLine($"Valor do saque");
    double valorSolicitado = double.Parse(Console.ReadLine());

    //VALIDAR SE PODE SACAR OU NÃO 
    if (saldos[idCliente] >= valorSolicitado)
    {
        //ATUALIZAR O SALDO DA CONTA
        saldos[idCliente] -= valorSolicitado;
        System.Console.WriteLine($"Saque realizado com sucesso!");
    }
    else
    {
        System.Console.WriteLine($"Saldo insuficiente");
    }
    
    Console.WriteLine("Função em Desenvolvimento...");

}
int BuscarCliente()
{
    Console.WriteLine("Digite o número do cliente:");
    int idCliente = int.Parse(Console.ReadLine());

    if (idCliente < 0 || idCliente >= totalClientes)
    {
        Console.WriteLine("Cliente não encontrado");
        return -1;
    }

    return idCliente;
}


void Transferir()
{
    //buscar cliente - conta de origem
    //buscar cliente - conta de destino
    //pedir o valor do saque
    //verificar se a conta de origem tem saldo pra transferir
    // se tiver, transfere (debita saldo da conta origem e adiciona saldo na conta destino)

    
    //Buscar cliente - conta de origem
    //Buscar cliente - conta de destino
    //pedir o valor do saque
    //verificar se a conta de origem tem saldo para transferir
    //se tiver, transfere (debita saldo na conta de origem e adiciona saldo na conta)


    Console.WriteLine($"===Trasferência===");
    Console.WriteLine($"Conta de origem: ");
    int idClienteOrigem = BuscarCliente();

    if (idClienteOrigem == -1)
    {
        return;
    }

    Console.WriteLine($"Conta de Destino: ");
    int idClienteDestino = BuscarCliente();
    if (idClienteDestino == -1)
    {
        return;
    }

    Console.Write($"Valor para trasferir: ");
    double valor = double.Parse(Console.ReadLine());

    if (saldos[idClienteOrigem] >= valor)
    {// tem saldo para tranferir
        saldos[idClienteOrigem] -= valor;
        saldos[idClienteOrigem] += valor;
        Console.WriteLine($"Transferência concluída!");
    }

    else//não tem saldo
    {
        Console.WriteLine($"Saldo Insuficiente!");
    }

}

void ListarClientes()
{
    Console.WriteLine($"======== Lista de Clientes ========");
    for (int i = 0; i < totalClientes; i++)
    {
        Console.WriteLine($"{i} - {nomes[i]} | Saldo: R$ {saldos[i]:F2}");
        Console.WriteLine();
    }

}

int buscarCliente()
{
    ListarClientes();//desenha/exibe a lista de clientes
    Console.WriteLine($"Digite o número do cliente: ");
    int idCliente = int.Parse(Console.ReadLine());//posição do array onde ele está

    if (idCliente < 0 || idCliente >= totalClientes)
    {
        Console.WriteLine($"Cliente não encontrado");
        return -1;//cliente não encontrado
    }

    return idCliente;//retorna o id do cliente cadastrado
}