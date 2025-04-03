using System;

class program
{
    public static void Main(strign[] args){

        Double number1;
        Double number2;
        int escolha;

        Console.WriteLine("Digit eo primeiro número: ");
        number1 = double.Parse(Console.ReadLine());
        Console.WriteLine("");

        Console.WriteLine("Digite o segundo número: ");
        number2 = double.Parse(Console.ReadLine());

        Console.WriteLine("");

        Console.WriteLine("Escolha uma operação:\r\n1) Soma\r\n2) Subtração\r\n3) Multiplicação\r\n4) Divisão");
        escolha = int.Parse(Console.ReadLine());

        Console.WriteLine("");
        
        if (escolha == 1)
        {
            Console.WriteLine($"Soma: {number1} + {number2} = {number1 + number2}");
        }
        else if (escolha == 2)
        {
            Console.WriteLine($"Subtração: {number1} - {number2} = {number1 - number2}");
        }
        else if (escolha == 3)
        {
            Console.WriteLine($"Multiplicação: {number1} x {number2} = {number1 * number2}");
        }
        else if (escolha == 4)
        {
            Console.WriteLine($"Divisão: {number1} / {number2} = {number1 / number2}");
        }
        else
        {
            Console.WriteLine("Digite uma operação válida");
        }


    }
}