const int MAX = 20;

void Insere ( int [] fila, int valor, ref int fim )
{
    fila [fim] = valor;
    fim = fim + 1;
}

int Remove (int[]fila, ref int inicio)
{
    int valor = fila [inicio];
    inicio = inicio + 1;
    return valor;
}

bool EstaVazia ( int inicio, int fim)
{
    if (inicio == fim)
        return true;
    else
        return false;
}

bool EstaCheia ( int fim)
{
    if (fim == MAX)
        return true;
    else
        return false;
}

int Quantidade ( int [] fila)
{
    int i = 0;
    while (i < fila.Length)
        i += 1;

    return i;


}

void Lista ( int [] fila, int inicio, int fim)
{
    int i = inicio;
    while (i < fim)
    {
        Console.Write(fila[i]);
        i += 1;
    }
}

int Primeiro (int [] fila, int inicio)
{
    
    int valor = fila [inicio];
    return valor;
}

int [] fila_avioes = new int [MAX];
int inicio = 0;
int fim = 0;

string opcao = "0";
while (opcao != "6")
{
    Console.WriteLine("___________ MENU ___________");
    Console.WriteLine("_______Controle de Trafego Aéreo_______");
    Console.WriteLine("1- Adicionar aviões à fila de espera para decolagem");
    Console.WriteLine("2- Consultar a quantidade de aviões aguardando na fila");
    Console.WriteLine("3- Autorizar a decolagem de um avião da fila");
    Console.WriteLine("4- Listar os números de todos os aviões na fila ");
    Console.WriteLine("5- Consultar o número do primeiro avião da fila");
    Console.WriteLine("6 - Sair");
    Console.WriteLine("_______________________________");

    opcao = Console.ReadLine();

    if (opcao == "1")
    {
        Console.WriteLine("Adicionar o avião a fila: ");
        if (!EstaCheia(fim))
        {
            Console.WriteLine("Digite o código do avião");
            int valor = int.Parse(Console.ReadLine());
            Insere( fila_avioes,  valor, ref fim);
        }
        else 
            Console.WriteLine("Não é possivel novo cadastro. Aeroporto Congestionado");
    }

    else if (opcao == "2")
    {
        Console.WriteLine("Quantidade de aviões na fila");
        Console.WriteLine(Quantidade(fila_avioes));
    }

    else if (opcao == "3")
    {
        Console.WriteLine(" Autorizar a decolagem");
        if (!EstaVazia(inicio,fim))
            Console.WriteLine("Avião nº -"+Remove(fila_avioes, ref inicio)+"Autorizada a Decolagem");
        else
            Console.WriteLine("Não há aviões cadastrados");        
    }

    else if (opcao == "4")
    {
        Console.WriteLine(" Lista de aviões cadastrados");
        if (!EstaVazia(inicio,fim))
            Lista( fila_avioes, inicio, fim);
        else
            Console.WriteLine("Não há aviões cadastrados");
    }

    else if (opcao == "5")
    {
        Console.WriteLine("Primeiro Avião da Lista");
        if (!EstaVazia(inicio,fim))
        Console.WriteLine(Primeiro(fila_avioes,inicio));
        else 
        Console.WriteLine("Não há avioes cadastrados");
    }
}
