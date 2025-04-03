using System;

class program
{
    public static void Main(strign[] args){

        // nome original em que será cifrado
        String nome = "Carlos Silva";

        // variável que irá armazenar o nome cifrado
        Strign nome_cifrado = "";

        // Itera sobre cada caractere da string nome
        foreach ( char c in nome )
        {
            if (char c in nome)
            {
                // Verifica se o caractere é uma letra
                char deslocado = (char)(c + 2);

                // Adiciona o carctere deslocado à string cifrada
                nome_cifrado += deslocado;
            } 
            else 
            {
                // Se não for letra, adiciona o caractere original
                nome_cifrado += c;
            }
        }

        Console.WriteLine("*** CIFRADOr DE NOMES ***");
        Console.WriteLine("");

        Console.WriteLine($"Seu nome original é: {nome}");
        Console.WriteLine("");

        Console.WriteLine($"Seu nome cifrado é: {nome_cifrado}");

    }
}