//Exercicio 09
// Evelin Mariana da Silva


Console.Clear();
const int Max = 20;
char [] pilha = new char [Max];
Console.Write("Digete uma frase: ");
string frase = Console.ReadLine();
int i = 0;
int topo = 0;

while (i < frase.Length)
{
    while ( i < frase.Length && frase[i] != ' ')
    {
        Insere ( pilha, ref topo, frase[i]);
        i = i + 1;

    }
    while (EstaVazia(topo) == false)
    {
        char x = Remove (pilha, ref topo);
        Console.Write (x);
    }
    i++;
    Console.Write(" ");
}


// Funções 
void Insere(char[] p, ref int t, char v)
{
    p[t] = v;
    t += 1;
}

char Remove(char[] p, ref int t)
{
    t -= 1;
    return(p[t]);
}

bool EstaVazia(int t)
{
    if(t == 0)
        return true;
    
    else
        return false;
}
bool EstaCheia(int t)
{
    if (t == Max)
        return true;
    
    else
        return false;
}