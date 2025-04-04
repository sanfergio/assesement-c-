using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("*** birthday system! ***");
        Console.WriteLine();

        // definindo a data de nascimento
        Console.WriteLine("digite a data do seu nascimento no formato (dd/MM/yyyy): ");
        DateTime dataNascimento = DateTime.Parse(Console.ReadLine());
 
        // data atual
        DateTime dataAtual = DateTime.Now;

        // próximo aniversário usando o ano atual
        DateTime proximoAniversario = new DateTime(dataAtual.Year, dataNascimento.Month, dataNascimento.Day);

        // se o aniversário já passou este ano, considerar o próximo ano

        if (proximoAniversario < dataAtual)
        {
            proximoAniversario = proximoAniversario.AddYears(1);
        }

        // diferença total em dias
        TimeSpan diferenca = proximoAniversario - dataAtual;

        Console.WriteLine($"Faltam {diferenca.Days} dias para o seu próximo aniversário!");

        if (diferenca.Days < 7)
        {
            Console.WriteLine($"seu aniversário é em {diferenca.Days} dias! seu dia mais especial e mais daora ta chegando!");
        }


    }
}