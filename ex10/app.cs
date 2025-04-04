using System;

class Program
{
    public static void Main(string[] args)
    {
        Random random = new Random();
        int aleatorio = random.Next(1, 50);
        int user;
        int tentativas = 5;

        Console.WriteLine("*** random game ***");
        Console.WriteLine("");
        Console.WriteLine("Qual o número foi gerado?");

        while (tentativas > 0)
        {
            Console.WriteLine($"Você tem {tentativas} tentativa restante");
            user = int.Parse(Console.ReadLine());

            if (user == aleatorio)
            {
                Console.WriteLine($"Você acertou! O número era {aleatorio}");
                return;
            }
            else
            {
                Console.WriteLine("Você errou!");
                tentativas--;
            }
        }

        Console.WriteLine($"Suas tentativas acabaram! O número correto era: {aleatorio}");
    }
}
