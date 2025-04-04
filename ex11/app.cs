
public class Contatos
{
    // declarando o array de contatos e seus atributos
    private (string Nome, string Numero, string Email)[] contatos = new (string, string, string)[3];
    private int contatoIndex = 0;

    // metodo para listar os contatos
    public void Listar_Contato()
    {
        Console.WriteLine("");
        Console.WriteLine("*** LISTA DE CONTATOS ***");
        Console.WriteLine("");

        {
            // define o caminho e nome do arquivo
            string caminhoArquivo = "contatos.txt";

            // verifica se o arquivo existe
            if (!File.Exists(caminhoArquivo))
            {
                Console.WriteLine("Nenhum contato cadastrado.\n");
                return;
            }

            // cria um StreamReader para ler o arquivo
            using (StreamReader reader = new StreamReader(caminhoArquivo))
            {
                string linha;
                Console.WriteLine("\nConteúdo do arquivo:\n");

                // lê e exibe cada linha do arquivo
                while ((linha = reader.ReadLine()) != null)
                {
                    Console.WriteLine(linha);
                }
            }

            Console.WriteLine("\nLeitura concluída!\n");
        }
    }

    // metodo para inserir os contatos
    public void Inserir_Contato(string Nome, string Numero, string Email)
    {
        // define o caminho do arquivo
        string caminhoArquivo = "contatos.txt";

        // abre o arquivo em modo APPEND (adiciona no final)
        using (StreamWriter writer = new StreamWriter(caminhoArquivo, true)) // true = append
        {

            // add o novo contato
            writer.WriteLine($"\n{Nome},{Numero},{Email}");
            
        }

        Console.WriteLine("\nContato cadastrado com sucesso!\n");
    }



    class Program
    {
        public static void Main(string[] args)
        {
            int escolha;

            // instanciando a classe Agenda
            Contatos agenda1 = new Contatos();

            // loop para o menu de opções
            while (true)
            {
                string nome;
                string numero;
                string email;

                Console.WriteLine("");
                Console.WriteLine("=== Gerenciador de Contatos ===");
                Console.WriteLine("");
                Console.WriteLine("Escolha uma opção:\n1) Inserir Contato\n2) Listar Contatos\n3) Sair");
                Console.WriteLine("");
                escolha = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                // opção para inserir os contatos
                if (escolha == 1)
                {
                    Console.WriteLine("Insira o nome do contato");
                    nome = Console.ReadLine();

                    Console.WriteLine("");

                    Console.WriteLine("Insira o número do contato");
                    numero = Console.ReadLine();

                    Console.WriteLine("");

                    Console.WriteLine("Insira o email do contato");
                    email = Console.ReadLine();

                    agenda1.Inserir_Contato(nome, numero, email);
                }

                // opção para listar os contatos
                else if (escolha == 2)
                {
                    Console.WriteLine("Contatos cadastrados:");
                    Console.WriteLine("");
                    agenda1.Listar_Contato();
                }

                // opção para sair do programa
                else if (escolha == 3)
                {
                    Console.WriteLine("Encerrando programa...");
                    break;
                }

                // opção caso inserir um valor inválido
                else
                {
                    Console.WriteLine("Insira um valor válido!");
                }
            }
        }
    }

}