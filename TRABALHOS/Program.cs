static int potencia (int x, int y) // x == base , y == expoente
{
    if ( y == 0)
        return 1;
    else if ( y == 1)
        return x;
    else 
        return x * potencia ( x , y -1);

}

static void cubo (int b_2, int num)
{
    if (b_2 <= num)
    {
        Console.WriteLine( b_2* b_2* b_2);
        cubo( b_2+1 , num);
    }

}

static int MDC ( int num1, int num2)
{
    if (num1 == num2)
        return num1;
    else if (num1 < num2)
        return MDC (num2, num1);
    else 
        return MDC (num1 - num2, num2);
}

static int fib_rec (int n) // Fibonacci Recursiva
{
    if (n == 0 || n == 1 )
        return n;
    else
        return fib_rec (n- 1) + fib_rec ( n - 2);
}

static int fib_inter (int n) // Fibonacci Iterativa
{
    int a = 0, b = 1 , c=0 , i = 2;
    if ( n == 1)
        return a;
    else if ( n == 2 )
        return b;
    else
        while (i < n)
        {
            c = a + b ;
            a = b ;
            b = c;
            i++;
        
        }
    return c;
}
static void binario (int num) // Função Binário
{
    if (num != 0)
    {
        binario (num / 2);
        Console.Write(num % 2);
    }
}

string opcao = "0";
while (opcao != "6")
{
    Console.WriteLine("\n"+
                "__________________ MENU __________________\n"+
                "2. Potência\n"+
                "3. Cubo\n"+
                "4. MDC\n"+
                "5. Recursiva\n"+
                "6. Iterativa\n"+
                "7. Binário\n"+
                "8. Sair\n"+
                "______ Informe a opção desejada ______");
    
    opcao = Console.ReadLine();
    if (opcao == "2")
    {
        int x , y ;
        Console.Write("Informe a base: ");
        x = int.Parse(Console.ReadLine());
        Console.Write("Informe o expoente: ");
        y = int.Parse(Console.ReadLine());

        int resultado = potencia ( x, y);
        Console.Write("Resultado de {0} ^ {1} = {2}", x, y, resultado);
    }
    else if (opcao == "3")
    {
        int num;
        Console.Write("Informe o número: ");
        num = int.Parse(Console.ReadLine());
        cubo(1,num);
        
    }
   
    else if (opcao == "4")
    {
        int num1, num2;
        Console.Write("Informe o primeiro número: ");
        num1 = int.Parse(Console.ReadLine());
        Console.Write("Informe o segundo número: ");
        num2 = int.Parse(Console.ReadLine());
        int resultado = MDC (num1, num2);
        Console.Write (" O MDC de {0} e {1} é {2}", num1, num2, resultado);
    }
    else if (opcao == "5")
    {
        int num_rec, resultado;
        Console.Write("Informe um número: ");
        num_rec = int.Parse(Console.ReadLine());
        resultado = fib_rec(num_rec);
        Console.Write("Resultado de Fibonacci de {0} é {1}", num_rec, resultado);
    }

    else if (opcao == "6")
    {
        int n1, resultado;
        Console.Write("Informe um número: ");
        n1 = int.Parse(Console.ReadLine());
        resultado = fib_inter(n1);
        Console.Write("Resultado de Fibonacci de {0} é {1}", n1, resultado);
    }
    else if (opcao == "7")
    {
        int num;
        Console.Write("Informe o número para converrsão: ");
        num = int.Parse(Console.ReadLine());
        Console.Write("O binario de {0} é ", num);
        binario(num);


    }
    Console.ReadKey();

   
}
