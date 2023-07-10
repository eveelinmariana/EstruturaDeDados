/*
18) Faça um programa que utilize lista encadeada e que tenha as opções a seguir. O nó deve conter os atributos: nome, idade, whats e prox.
    a) Incluir conforme apresentado em aulas
    b) Para alterar, consulte pelo nome. Se encontrar, exiba os valores atuais e permita a alteração. Caso não encontre, exiba mensagem de não encontrado.
    c) Para excluir, procure pelo nome. Se encontrar, exiba os valores atuais e permita a exclusão. Caso não encontre, exiba mensagem de não encontrado.
    d) Na opção exibir, exiba todos os registros.
*/

tipo_no lista = null;

while(true)
{
    int op = Menu();
    if(op == 1)
    {
        Console.WriteLine("******** INCLUINDO ********");
        Console.Write("\nDigite um nome para ser incluido na lista: ");
        string nome_incluir = Console.ReadLine();
        Console.Write("Digite uma idade a ser inlcuida na lista: ");
        string idade_incluir = Console.ReadLine();
        Console.Write("Digite o número do WhatsApp a ser incluido na lista: ");
        string whats_incluir = Console.ReadLine();
        Console.WriteLine();
        Insere(ref lista, nome_incluir, idade_incluir, whats_incluir);
    }
    else if(op == 2)
    {
        Alterar(lista);
    }
    else if(op == 3)
    {
        Console.WriteLine("******** REMOVENDO ********\n");
        if(lista != null)
        {
            tipo_no remover = Remove(ref lista);
            Console.WriteLine($"O valor removido da lista foi: {remover.nome}");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Não existem valores a serem removidos [LISTA VAZIA]!\n");
        }
    }
    else if(op == 4)
    {
        Exibir(lista);
    }
    else if(op == 5)
    {
        Console.WriteLine("FIM DO PROGRAMA...\n");
        break;
    }
}

void Insere(ref tipo_no lista, string n, string i, string w)
{
    tipo_no no = new tipo_no();
    no.nome = n;
    no.idade = i;
    no.whats = w;
    if(lista != null)
    {
        no.proximo = lista;
    }
    lista = no;
}

void Consultar(tipo_no lista, string n_procurado, ref tipo_no anterior, ref tipo_no atual)
{
    atual = lista;
    anterior = null;
    while(atual != null && n_procurado != atual.nome)
    {
        anterior = atual;
        atual = atual.proximo;
    }
}

void Alterar(tipo_no lista)
{
    string nome_procurado = "";
    tipo_no anterior = null;
    tipo_no atual = null;
    Console.Write("Digite o nome que deseja procurar: ");
    nome_procurado = Console.ReadLine();
    Consultar(lista, nome_procurado, ref anterior, ref atual);
    if(atual != null)
    {
        Console.WriteLine("\n********* DADOS ATUAIS *********");
        Console.WriteLine("\nNome "+atual.nome);
        Console.WriteLine("Idade "+atual.idade+" anos");
        Console.WriteLine("WhatsApp "+atual.whats);
        Console.WriteLine("\n********* FIM DOS DADOS ATUAIS! *********");
        Console.WriteLine("\nDeseja alterar algum dado da lista? ");
        Console.WriteLine("1 - SIM");
        Console.WriteLine("2 - NÃO");
        Console.Write("SIM ou NÃO: ");
        int alterar = Convert.ToInt32(Console.ReadLine());
        if(alterar == 1)
        {
            Console.Write("\nNovo nome: ");
            atual.nome = Console.ReadLine();
            Console.Write("Nova idade: ");
            atual.idade = Console.ReadLine();
            Console.Write("Digite o novo WhatsApp: ");
            atual.whats = Console.ReadLine();
        }
        else if(alterar == 2)
        {
            Console.WriteLine("NÃO TIVERAM DADOS ALTERADOS!");
        }
    }
    else
    {
        Console.WriteLine("\nNome não encontrado, tente novamente!");
    }
}

void Exibir(tipo_no lista)
{
    Console.WriteLine("\n********* EXIBIÇÃO DE TODOS OS REGISTROS *********");
    tipo_no auxiliar = lista;
    while(auxiliar != null)
    {
        Console.WriteLine("\nNome "+auxiliar.nome);
        Console.WriteLine("Idade "+auxiliar.idade+" anos");
        Console.WriteLine("WhatsApp "+auxiliar.whats);
        auxiliar = auxiliar.proximo;
    }
}

/*tipo_no Remove(ref tipo_no lista)
{
    tipo_no no = null;
    if(lista != null)
    {
        no = lista;
        lista = lista.proximo;
        no.proximo = null;
    }
    return no;
}*/

tipo_no Remove(ref tipo_no lista)
{
    tipo_no no = null;
    if(lista != null)
    {
        no = lista;
        Console.Write("Digite o nome que deseja excluir: ");
        string nome_excluir = Console.ReadLine();
        
    }
}

int Menu()
{
    int opcao = 0;
    Console.WriteLine("---------------------------MENU PRINCIPAL---------------------------\n");
    Console.WriteLine("[1] Incluir!");
    Console.WriteLine("[2] Alterar!");
    Console.WriteLine("[3] Remover!");
    Console.WriteLine("[4] Exibir todos!");
    Console.WriteLine("[5] Sair!");
    Console.Write("\nDigite a opção desejada: ");
    opcao = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("\n------------------------------------------------------------------\n");
    return opcao;
}
class tipo_no
{
    public string nome = "";
    public string idade = "";
    public string whats = "";
    public tipo_no proximo = null;
}