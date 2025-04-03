using System;
public class Funcionario
{
    // atributos (ou campos)
    public string Nome;
    public string Cargo;
    public double Salario_Base;

    // metodo para exibir as informações do funcionario
    public void Exibir()
    {
        Console.WriteLine($"Funcionário: {Nome}\nCargo: {Cargo}\nSalarío Base: {Salario_Base}");
    }


    // metodo para exibir as informações do gerente

    public void Gerente()
    {
        if (Cargo == "Gerente")
        {
            Console.WriteLine($"Receba 20% de bonus no salario {Nome}");
            Salario_Base = (Salario_Base * 0.20) + Salario_Base;
        }


    }



}
class Program
{
    public static void Main(string[] args)
    {
        Funcionario funcionario1 = new Funcionario();
        funcionario1.Nome = "Giovani Marlon";
        funcionario1.Cargo = "Gerente";
        funcionario1.Salario_Base = 1500;

        funcionario1.Exibir();
        Console.WriteLine("");

        funcionario1.Gerente();
        Console.WriteLine("");

        funcionario1.Exibir();


    }
}
using System;
public class Funcionario
{
    // atributos (ou campos)
    public string Nome;
    public string Cargo;
    public double Salario_Base;

    // metodo para exibir as informações do funcionario
    public void Exibir()
    {
        Console.WriteLine($"Funcionário: {Nome}\nCargo: {Cargo}\nSalarío Base: {Salario_Base}");
    }


    // metodo para exibir as informações do gerente

    public void Gerente()
    {
        if (Cargo == "Gerente")
        {
            Console.WriteLine($"Receba 20% de bonus no salario {Nome}");
            Salario_Base = (Salario_Base * 0.20) + Salario_Base;
        }


    }



}
class Program
{
    public static void Main(string[] args)
    {
        Funcionario funcionario1 = new Funcionario();
        funcionario1.Nome = "Giovani Marlon";
        funcionario1.Cargo = "Gerente";
        funcionario1.Salario_Base = 1500;

        funcionario1.Exibir();
        Console.WriteLine("");

        funcionario1.Gerente();
        Console.WriteLine("");

        funcionario1.Exibir();

        Funcionario funcionario2 = new Funcionario();
        funcionario2.Nome = "Marlon Giovani";
        funcionario2.Cargo = "Dev. Jr";
        funcionario2.Salario_Base = 1200;

        Console.WriteLine("");

        funcionario2.Exibir();
        Console.WriteLine("");

        funcionario2.Gerente();
        Console.WriteLine("");

        funcionario2.Exibir();



    }
}
