using System;
public class ContaBancaria
{
    // atributos (ou campos)
    public string Titular;


    // definindo saldo como privado 
    private decimal Saldo;

    // metodo para exibir as informações do saldo
    public void ExibirSaldo()
    {
        Console.WriteLine($"Saldo atual: R$ {Saldo} ");
    }


    // metodo para exibir as informações do titular

    public void ExibirUser()
    {
        Console.WriteLine($"***** Banco do Brasil *****\nTitular: {Titular}");
    }


    // metodo para exibir o saque

    public void Sacar(decimal Saque)
    {
        if (Saldo <= 0)
        {
            Console.WriteLine("Saldo insuficiente para realizar o saque!");
        }
        else if (Saque > Saldo)
        {
            Console.WriteLine("Saldo insuficiente para realizar o saque!");
        }
        else
        {
            Console.WriteLine($"Saque de R$ {Saque} realizado com sucesso!");
            Saldo = Saldo - Saque;
        }
    }


    // metodo para exibir o deposito

    public void Depositar(decimal Deposito)
    {
        if (Deposito <= 0)
        {
            Console.WriteLine("O valor do depósito deve ser positivo!");
        }
        else
        {
            Console.WriteLine($"Depósito de R$ {Deposito} realizado com sucesso!");
            Saldo = Saldo + Deposito;

        }

    }


}
class Program
{
    public static void Main(string[] args)
    {
        ContaBancaria Conta1 = new ContaBancaria();
        Conta1.Titular = "Giovani Marlon";

        Conta1.ExibirUser();
        Console.WriteLine("");

        Conta1.ExibirSaldo();
        Console.WriteLine("");

        Conta1.Sacar(200);
        Console.WriteLine("");

        Conta1.ExibirSaldo();
        Console.WriteLine("");

        Conta1.Depositar(500);
        Console.WriteLine("");

        Conta1.ExibirSaldo();
        Console.WriteLine("");

        Conta1.Sacar(200);
        Console.WriteLine("");

        Conta1.ExibirSaldo();

    }
}
