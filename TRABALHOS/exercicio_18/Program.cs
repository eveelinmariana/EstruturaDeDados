// exercicio 18
tipo_no lista = null;

while(true)
{
    int opcao = Menu();
    if(opcao == 1)
    {
        Console.WriteLine("________INSERINDO________\n");
        Console.Write("INFORME O NOME: ");
        string nome_incluir = Console.ReadLine();
        Console.Write("INFORME A IDADE: ");
        string idade_incluir = Console.ReadLine();
        Console.Write("INFORME O WHATSAPP: ");
        string whats_incluir = Console.ReadLine();
        Console.WriteLine();
        Insere(ref lista, nome_incluir, idade_incluir, whats_incluir);
    }
    else if(opcao == 2)
    {
        Alterar(lista);
    }
    else if(opcao == 3)
    {
        Console.WriteLine("________REMOVENDO________\n");
        if(lista != null)
        {
            tipo_no remover = Remove(ref lista);
            Console.WriteLine($"OS DADOS DE",{remover.nome},"FORAM REMOVIDOS");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("lISTA ESTÁ VAZIA\n");
        }
    }
    else if(opcao == 4)
    {
        Exibir(lista);
    }
    else if(opcao == 5)
    {
        Console.WriteLine("FIM DO PROGRAMA");
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
    Console.Write("DIGITE O NOME QUE DESEJA PROCURAR: ");
    nome_procurado = Console.ReadLine();
    Consultar(lista, nome_procurado, ref anterior, ref atual);
    if(atual != null)
    {
        Console.WriteLine("\n________DADOS ATUAIS________");
        Console.WriteLine("\nNome "+atual.nome);
        Console.WriteLine("Idade "+atual.idade+" anos");
        Console.WriteLine("WhatsApp "+atual.whats);
        Console.WriteLine("\n________FIM DOS DADOS ATUAIS!________");
        Console.WriteLine("\nDeseja alterar algum dado da lista? ");
        Console.WriteLine("1 - SIM");
        Console.WriteLine("2 - NÃO");
        Console.Write("SIM ou NÃO: ");
        int alterar = Convert.ToInt32(Console.ReadLine());
        if(alterar == 1)
        {
            Console.Write("\nNOME ATUALIZADO: ");
            atual.nome = Console.ReadLine();
            Console.Write("IDADE ATUALIZADO: ");
            atual.idade = Console.ReadLine();
            Console.Write("WHATSAPP ATUALIZADO: ");
            atual.whats = Console.ReadLine();
        }
        else if(alterar == 2)
        {
            Console.WriteLine("DADOS NÃO FORAM ATUALIZADOS!");
        }
    }
    else
    {
        Console.WriteLine("\nNOME NÃO ENCONTRADO!");
    }
}

void Exibir(tipo_no lista)
{
    Console.WriteLine("\n________EXIBIÇÃO DE TODOS OS REGISTROS________");
    tipo_no auxiliar = lista;
    while(auxiliar != null)
    {
        Console.WriteLine("\nNome "+auxiliar.nome);
        Console.WriteLine("Idade "+auxiliar.idade+" anos");
        Console.WriteLine("WhatsApp "+auxiliar.whats);
        auxiliar = auxiliar.proximo;
    }
}



tipo_no Remove(ref tipo_no lista)
{
    tipo_no no = null; atual= null;
    string np;
    Console.Write("NOME PROCURADO: ");
    np = Console.ReadLine();
    Consultar(lista, np, ref anterior, ref atual);
    if ( atual != lista)
    {
        {
            if (atual == lista)

        }
        
        else if (atual.proximo==null)
        {
            anterior.proximo = null;
        }
        else 
        {
            anterior.proximo = atual.proximo;
            atual.proximo = null;
        }
    }
    else
    Console.WriteLine("NÃO ENCONTRADO")

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