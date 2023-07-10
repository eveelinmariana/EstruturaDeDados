// Funções 
void Insere(ref tipo_no_lista,string nome, string idade, string whats )
{

}


//Menu 
string opcao = "0";
while(opcao != "5")
{
    Console.Write("1- Incluir");
    Console.Write("2- Alterar");
    Console.Write("3- Excluir");
    Console.Write("4- Exibir");
    Console.Write("Informe a opção desejada");
    opcao = Console.ReadLine();

    if (opcao == "1")
    {
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.Write("Idade: ");
        string idade = Console.ReadLine();
        Console.Write("WhatsApp: ");
        string whats = Console.ReadLine();

        Insere()
    }

}






class tipo_no
{
    public string nome, idade, whats;
    public tipo_no prox = null;
}