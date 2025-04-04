class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("*** Formatura Infnet ***");
        Console.WriteLine("");

            // definindo a data atual

            Console.WriteLine("digite a data atual no formato (dd/mm/aaaa): ");
            DateTime dataUser = DateTime.Parse(Console.ReadLine());

            // definindo a data de formatura
            DateTime formatura = new DateTime(2027, 07, 31);

            // definindo a data atual verificada pelo datatime.now
            DateTime dataNow = DateTime.Now;

            // diferença em dias da formatura e data atual
            int dias = formatura.Day - dataUser.Day; 

            // diferença do total em dias

            TimeSpan Totaldiferenca = formatura - dataUser;

            // diferença em meses
            int meses = formatura.Month - dataUser.Month;

            // diferença em anos
            int anos = formatura.Year - dataUser.Year;

            // se a data que o usuario informar for maior (mais recente) que a data atual, o programa não deve aceitar
            if (dataUser > dataNow)
            {
                Console.WriteLine("Erro: A data informada não pode ser no futuro!");
             }

        else
        {

            // se a diferença total for menor que 0, o programa não deve aceitar porque o aluno já deveria ter se formado antes dessa data

            if (Totaldiferenca.Days < 0)
            {
                Console.WriteLine("Parabéns! Você já deveria estar formado!");
            }


            // caso o aluno não tenha se formado ainda

            else
            {
                Console.WriteLine($"\nFaltam {meses} meses e {dias} dias para a formatura");

                // caso o formatura tiver 6 meses proximos

                if (meses < 6) { Console.WriteLine("A reta final chegou! Prepare-se para a formatura!"); }

            }

        }
        
      
    }

}