// exercicio 24 - arvore binária 
// funções
void Insere(ref tp_no raiz, int valor)
{
   if (raiz == null)
   {
      raiz = new tp_no();
      raiz.valor = valor;
   }
   else if (valor < raiz.valor)
      Insere(ref raiz.esq, valor);
   else
      Insere(ref raiz.dir, valor);
}

tp_no Busca(tp_no raiz, int valor)
{
   if (raiz == null)
      return null;
   else if (valor == raiz.valor)
      return raiz;
   else if (valor < raiz.valor)
      return Busca(raiz.esq, valor);
   else
      return Busca(raiz.dir, valor);
}
tp_no RetornaMaior(ref tp_no raiz)
{
   if (raiz.dir == null)
   {
      tp_no p = raiz;
      raiz = raiz.esq;
      return p;
   }
   else
      return RetornaMaior(ref raiz.dir);
}

tp_no Remove(ref tp_no raiz, int remover)
{
   if (raiz == null)
      return null;     
   else if (remover == raiz.valor)
   {       
      tp_no ponteiro = raiz;
      if (raiz.esq == null)        // nao tem filho esquerdo
         raiz = raiz.dir;
      else if (raiz.dir == null)  // nao tem filho direito
         raiz = raiz.esq;
      else                          // tem ambos os filhos
      {
         ponteiro = RetornaMaior(ref raiz.esq);
         raiz.valor = ponteiro.valor;
      }
      return ponteiro;
   }
   else if (remover < raiz.valor)
      return Remove(ref raiz.esq, remover);
   else
      return Remove(ref raiz.dir, remover);
}

void pre_ordem(tp_no raiz)
{
   if (raiz != null)
   {
      Console.Write(raiz.valor+" ");
      pre_ordem(raiz.esq);
      pre_ordem(raiz.dir);
   }
}

void pos_ordem(tp_no raiz)
{
   if (raiz != null)
   {
      pos_ordem(raiz.esq);
      pos_ordem(raiz.dir);
      Console.WriteLine(raiz.valor+" ");
   }
}
void ordem(tp_no raiz)
{
   if (raiz != null)
   {
      ordem(raiz.esq);
      Console.Write(raiz.valor+" ");
      ordem(raiz.dir);
   }
}


// MENU

tp_no raiz = null;
Console.Clear();
int opcao = 0;
while (opcao != 4)
{
   Console.Write("____________________ MENU ____________________ ");
   Console.Write("1- Inserir");
   Console.Write("2- Pesquisar");
   Console.Write("3- Remover");
   Console.Write("4- Exibir");
   Console.Write("5- Sair");
   opcao = Convert.ToInt32(Console.ReadLine());

    if (opcao == 1)
    {
        Console.Write("__________INSERIR__________");
        Console.Write("INFORME UM VALOR: ");
        int valor = Convert.ToInt32(Console.ReadLine());
        Insere(ref raiz, valor);

    }

    else if (opcao == 2)
    {
        Console.Write("__________PESQUISAR__________");
        Console.Write("DIGITE O NÚMERO A SER PROCURADO");
        int num_pesquisa = Convert.ToInt32(Console.ReadLine());
        if (Busca(raiz,num_pesquisa) != null)
        {
         Console.Write("Valor Encontrado!\n");
        }
        else
        {
         Console.Write("Valor não encontrado!\n");
        }
    }

    else if (opcao == 3)
    {
      Console.WriteLine("__________REMOVER__________");
      Console.Write("\nDigite o valor a ser removido: ");
      int num_remover = int.Parse(Console.ReadLine());
      Busca(raiz, num_remover);
      if(Busca(raiz, num_remover) != null)
      {
         Console.WriteLine("\nValor encontrado!");
         Remove(ref raiz, num_remover);
         Console.WriteLine("\nO valor informado foi removido!\n");
      }
      else
      {
         Console.WriteLine("\nValor não encontrado!");
      }
   }
      else if(opcao == 4)
   {
      Console.WriteLine("__________EXIBIR__________");
      Console.WriteLine("\nINFORME COMO DESEJA VISUALIZAR OS DADOS?\n");
      Console.WriteLine("[1] Em ordem");
      Console.WriteLine("[2] Pré ordem");
      Console.WriteLine("[3] Pós ordem");
      Console.WriteLine("[4] Digite 4 para sair");
      Console.Write("\nDigite a opção desejada: ");
      int op_exibicao = Convert.ToInt32(Console.ReadLine());
      if(raiz != null)
         if(op_exibicao == 1)
         {
            Console.WriteLine("\n__________EXIBIR EM ODER__________\n");
            ordem(raiz);
            Console.WriteLine("");
            Console.WriteLine("");
         }
         else if(op_exibicao == 2)
         {
            Console.WriteLine("\n__________EXIBIR EM PRÉ ODER__________\n");
            pre_ordem(raiz);
            Console.WriteLine("");
            Console.WriteLine("");
         }
         else if(op_exibicao == 3)
         {
            Console.WriteLine("\n__________EXIBIR EM PÓS ODER__________\n");
            pos_ordem(raiz);
            Console.WriteLine("");
            Console.WriteLine("");
         }  
         else if(op_exibicao == 4)
         {
            Console.WriteLine("\nSaindo do modo de exibição\n");
         }       
      else
      {
         Console.WriteLine("\nA ÁRVORE ESTÁ VAZIA\n");
      }   
   }
   else if(opcao == 5)
   {
      
      Console.WriteLine("PROGRAMA ENCERRADO!");
      break;
   }
}
class tp_no
{
   public tp_no esq;
   public int valor;
   public tp_no dir;
}
