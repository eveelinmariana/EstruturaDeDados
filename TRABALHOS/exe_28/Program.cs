
const int N = 5;

         int hash(int chave)
        {
            return (chave % N);
        }
void inserir(ref tp_no[] v, int c, string nome, int whats, int op1)
    {
        if (op1 == 1)
        {
            tp_no no = new tp_no();

            int pos = hash(c);
            no.idade = c;
            no.nome = nome;
            no.whats = whats;

            v[pos] = no;
        }

        else if (op1 == 2)
        {
            tp_no no = new tp_no();

            int pos = hash(c);
            no.idade = c;
            no.nome = nome;
            no.whats = whats;

            while (v[pos] != null)
            {
                pos++;
                pos = pos % N;
            }
            v[pos] = no;
        }

        else if (op1 == 3)
        {
                tp_no no = new tp_no();
    
            int pos = hash(c);
            no.idade = c;
            no.nome = nome;
            no.whats = whats;
            
            if (v[pos] != null)
                no.prox = v[pos];

            v[pos] = no;
        }
    }

bool verificarVazio(tp_no[] v)
    {
        int i = 0, cont = 0;

        while (v[i] == null && cont < N)
        {
            i++;
            i = i % N;
            cont++;
        }

        if (cont >= N)
            return true; // esta vazio
        else
            return false; // não vazio.
    }

int recuperarSemTrat(tp_no[] v, int c)
    {
        int pos = hash(c);

        if (v[pos] == null || v[pos].idade != c)
            return -1;                
        else
            return pos;
    }

int recuperarLinear(tp_no[] v, int c)
    {
        int pos = hash(c);
        int cont = 0;
        int stop = 0;

        if (v[pos] == null)
        {
            return -1;
        }

        else
        {
            while (v[pos] != null && cont <= N && stop == 0)
            {
                if (v[pos].idade != c)
                {
                    pos++;
                    pos = pos % N;
                    cont++;;
                }

                else
                {
                    stop++;
                }                    
            }

            if (cont <= N && v[pos] != null)
                return pos;
            else if (cont <= N && v[pos] == null)
                return -1;
            else
                return -1;
        }
    }
 void recuperarListaEncadeada(tp_no[] v, int c)
    {
        int pos = hash(c);
        tp_no no;

        if (v[pos] == null)
        {
            Console.WriteLine("Não foram encontrados resultados.");
        }
        else
        {
            no = v[pos];

            while (no != null && no.idade != c)
            {
                no = no.prox;
            }

            if (no != null)
            {

                
                Console.WriteLine("\nDeseja alterar o nome e o whats? (S/N)");
                char yesno = char.Parse(Console.ReadLine());

                if (yesno == 's' || yesno == 'S')
                {
                    Console.WriteLine("Novo nome:");
                    no.nome = Console.ReadLine();

                    Console.WriteLine("Novo Whats:");
                    no.whats = int.Parse(Console.ReadLine());

                    Console.WriteLine("Dados alterados.");
                }
            }

            else
            {
                Console.WriteLine("Não foram encontrados resultados.");
            }
        }
    }

void consultar(tp_no[] v, int op2)
    {
        Console.WriteLine("\nQual idade para buscar?");
        int age = int.Parse(Console.ReadLine());

        if (op2 == 1)
        {
            int aux = 0;

            aux = recuperarSemTrat(v, age);

            if (aux == -1)
            {
                Console.WriteLine("Nenhum registro encontrado.");
            }

            else
            {
                
                int idade = v[aux].idade;

                Console.WriteLine("\nDeseja alterar nome e whats? (S/N)");
                char yesno = char.Parse(Console.ReadLine());

                if (yesno == 's' || yesno == 'S')
                {
                    Console.WriteLine("Novo nome:");
                    v[aux].nome = Console.ReadLine();

                    Console.WriteLine("Novo whats:");
                    v[aux].whats = int.Parse(Console.ReadLine());

                    Console.WriteLine("Dados alterados");
                }

                else
                {
                    Console.WriteLine($"Dados foram mantidos.");
                }
            }
        }
        
        else if (op2 == 2)
        {
            int aux = 0;

            aux = recuperarLinear(v, age);

            if (aux == -1)
            {
                Console.WriteLine("Nenhum registro encontrado.");
            }

            else
            {
                
                int idade = v[aux].idade;

                Console.WriteLine("\nDeseja alterar nome e whats? (S/N)");
                char yesno = char.Parse(Console.ReadLine());

                if (yesno == 's' || yesno == 'S')
                {
                    Console.WriteLine("Novo nome:");
                    v[aux].nome = Console.ReadLine();

                    Console.WriteLine("Novo whats (M/F):");
                    v[aux].whats = int.Parse(Console.ReadLine());

                    Console.WriteLine("Dados alterados");
                }

                else
                {
                    Console.WriteLine($"Dados mantidos.");
                }
            }
        }
        
        else if (op2 == 3)
        {
            recuperarListaEncadeada(v, age);
        }
    }
void registroListaEncadeada(tp_no no)
    {
    
        int idade = no.idade;

    }

 void relatar(tp_no[] v, int op3)
    {
        bool vazio = verificarVazio(v);

        if (vazio == true)
        {
            Console.WriteLine("– Lista está vazia.");
        }

        else
        {
            if (op3 == 1)
            {
                for (int i = 0; i < v.Length; i++)
                {
                    if (v[i] != null)
                    {
                        
                        int idade = v[i].idade;

                        
                    }
                }
            }

            else if (op3 == 2)
            {
                for (int i = 0; i < v.Length; i++)
                {
                    if (v[i] != null)
                    {
                    
                        int idade = v[i].idade;

                    }
                }
            }

            else if (op3 == 3)
            {
                int i = 0;

                while (i < v.Length)
                {
                    if (v[i] == null)
                    {
                        i++;
                    }

                    else
                    {
                        tp_no no = new tp_no();

                        no = v[i];

                        while (no != null)
                        {
                            registroListaEncadeada(no);
                            no = no.prox;
                        }

                        i++;
                    }
                }
            }
        }
    }

tp_no[] semTratamento = new tp_no[N];
tp_no[] comTratLinear = new tp_no[N];
tp_no[] comTratListaEncadeada = new tp_no [N];

Console.WriteLine("Programa para registro de alunos.");

int op = 0;

    while (op != 4)
    {
        if (op != 0)
        {
            Console.WriteLine("Pressione Enter.");
            Console.ReadKey();
            Console.Clear();
        }

        Console.WriteLine(
            "\n---- MENU PRINCIPAL ----" +
            "\nDigite a opção desejada:" +
            "\n1. Inserir." +
            "\n2. Consultar/Alterar." +
            "\n3. Relatar." +
            "\n4. Sair.");
        op = int.Parse(Console.ReadLine());
        
        if (op == 1)
        {
            Console.WriteLine(
                "\nSubmenu:" +
                "\n1. Sem tratamento de colisão." +
                "\n2. Com tratamento de colisão linear." +
                "\n3. Com tratamento de colisão com lista encadeada.");
            int op1 = int.Parse(Console.ReadLine());

            if (op1 != 1 && op1 != 2 && op1 != 3)
            {
                Console.WriteLine("Opção inválida. Volte e digite um número de 1 a 3.");
            }
            
            else
            {
                Console.WriteLine("\nQuantos nomes deseja inserir?");
                int max = int.Parse(Console.ReadLine());

                for (int i = 0, j = 1; i < max; i++, j++)
                {
                    Console.WriteLine($"\n{j}º registro:");

                    Console.WriteLine("Nome:");
                    string name = Console.ReadLine();

                    Console.WriteLine("Idade:");
                    int age = int.Parse(Console.ReadLine());

                    Console.WriteLine("whats (M/F):");
                    int whats = int.Parse(Console.ReadLine());
                
                    if (op1 == 1)
                    {
                        inserir(ref semTratamento, age, name, whats, op1);
                    }
                    
                    else if (op1 == 2)
                    {
                        inserir(ref comTratLinear, age, name, whats, op1);
                    }
                    
                    else if (op1 == 3)
                    {
                        inserir(ref comTratListaEncadeada, age, name, whats, op1);
                    }
                }
            }            
        }
        
        else if (op == 2)
        {
            Console.WriteLine(
                "\n1. Sem tratamento de colisão." +
                "\n2. Com tratamento de colisão linear." +
                "\n3. Com tratamento de colisão com lista encadeada.");
            int op2 = int.Parse(Console.ReadLine());

            if (op2 != 1 && op2 != 2 && op2 != 3)
            {
                Console.WriteLine("Opção inválida. Volte e digite um número de 1 a 3.");
            }
            
            else
            {
                if (op2 == 1)
                {
                    consultar(semTratamento, op2);
                }

                else if (op2 == 2)
                {
                    consultar(comTratLinear, op2);
                }

                else if (op2 == 3)
                {
                    consultar(comTratListaEncadeada, op2);
                }
            }
        }
        
        else if (op == 3)
        {
            Console.WriteLine(
                "\n1. Sem tratamento de colisão." +
                "\n2. Com tratamento de colisão linear." +
                "\n3. Com tratamento de colisão com lista encadeada.");
            int op3 = int.Parse(Console.ReadLine());

            if (op3 != 1 && op3 != 2 && op3 != 3)
            {
                Console.WriteLine("Opção inválida. Volte e digite um número de 1 a 3.");
            }
            
            else
            {
                if (op3 == 1)
                {
                    Console.WriteLine("\nLista sem tratamento de colisão:");
                    relatar(semTratamento, op3);
                }

                else if (op3 == 2)
                {
                    Console.WriteLine("\nLista com tratamento de colisão linear:");
                    relatar(comTratLinear, op3);
                }

                else if (op3 == 3)
                {
                    Console.WriteLine("\nLista com tratamento de colisão com lista encadeada:");
                    relatar(comTratListaEncadeada, op3);
                }
            }
        }

        else if (op == 4)
        {
            Console.Clear();
        }

        else
        {
            Console.WriteLine("\nOpção inválida. Digite um número de 1 a 4.");
        }
    }

    Console.WriteLine("\nTérmino da execução do programa (pressione Enter para sair)...");
    Console.ReadKey();


 class tp_no
        {
            public int idade = 0; // Essa será a chave.
            public string nome;
            public int whats;
            public tp_no prox;
        }
