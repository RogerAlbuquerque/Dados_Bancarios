using System;



class Conta{
public int NumConta; 
public double Saldo;
public string NomeTitular;


public double AddSaldo(double deposito){

 return Saldo += deposito;
}

public double Saque(double saque){

 return Saldo = (Saldo - saque) - 5.00;
}


public override string ToString(){

return "Conta" + NumConta + ", titular: " + NomeTitular + ", Saldo: $ " + Saldo.ToString("F2");

 }
}


class principal
{

    
    static void Main(string[] args)
    {
        char escolha;
        
        Conta Alex = new Conta();

        Console.Write("Entre com o número da conta: ");
        Alex.NumConta = int.Parse(Console.ReadLine());


        Console.Write("Entre com o nome do titular da conta: ");
        Alex.NomeTitular = Console.ReadLine();

    inicio:

        Console.Write("Haverá depósito inicial (s/n)? ");
        escolha = char.Parse(Console.ReadLine());

        if(escolha == 'n'){ 
        Console.WriteLine(Alex.ToString());

        }

        else if(escolha == 's'){
            Console.WriteLine("Entre com um valor para depósito: ");
            Alex.AddSaldo(double.Parse(Console.ReadLine()));            
            
            Console.Clear();
            Console.WriteLine(Alex.ToString());
        }

        else {
        Console.Clear();
        Console.WriteLine("Essa opção não é valida");  
    
    goto inicio; }
        

        Console.WriteLine("Entre com um valor para saque: ");
        Alex.Saque(double.Parse(Console.ReadLine()));

        Console.WriteLine(Alex.ToString());


        

    }
}


/* 
Entre o número da conta: 8532
Entre o titular da conta: Alex Green
Haverá depósito inicial (s/n)? s

Entre o valor de depósito inicial: 500.00

Dados da conta:
Conta 8532, Titular: Alex Green, Saldo: $ 500.00

Entre um valor para depósito: 200.00

Dados da conta atualizados:
Conta 8532, Titular: Alex Green, Saldo: $ 700.00

Entre um valor para saque: 300.00

Dados da conta atualizados:
Conta 8532, Titular: Alex Green, Saldo: $ 395.00*/