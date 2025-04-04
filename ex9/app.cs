using System;
public class Estoque
{



    // declarando o array de produtos e seus atributos

    private (string Nome, int Quantidade, double Preco)[] produtos = new (string, int, double)[3];
    private int produtoIndex = 0;


    // metodo para listar os produtos
    public void Listar_Produto()
    {
        Console.WriteLine("");
        Console.WriteLine("*** LISTA DE PRODUTOS ***");
        Console.WriteLine("");
        foreach (var p in produtos)
            if (!string.IsNullOrEmpty(p.Nome))
                Console.WriteLine($"Produto: {p.Nome}| Quantidade: {p.Quantidade}| Preço: R${p.Preco:F2}");
        Console.WriteLine("");
    }



    // metodo para inserir os produtos
    public void Inserir_Produto(string Nome, int Quantidade, double Preco)
    {
        if (produtoIndex >= produtos.Length) return;
        produtos[produtoIndex++] = (Nome, Quantidade, Preco);
        Console.WriteLine($"\n{Nome} foi adicionado!\n");
    }

    // metodo para criar txt
    public void Criar_txt()
    {
        // define o caminho e nome do arquivo
        string caminhoArquivo = "estoque_produtos.txt";

            // cria um StreamWriter para escrever no arquivo
            using (StreamWriter writer = new StreamWriter(caminhoArquivo))
            {
                writer.WriteLine("*** RELATÓRIO DE ESTOQUE ***");
                writer.WriteLine("-----------------------------");

                // escreve cada produto no arquivo
                foreach (var p in produtos)
                {
                    if (!string.IsNullOrEmpty(p.Nome))
                    {
                        writer.WriteLine($"{p.Nome},{p.Quantidade},{p.Preco}");
                        writer.WriteLine("");
                    }
                }

            }

            Console.WriteLine("");
            Console.WriteLine($"arquivo '{caminhoArquivo}' criado com sucesso!\n");
        }

        }

class Program
{
    public static void Main(string[] args)
    {

        int escolha;

        Console.WriteLine("");
        Console.WriteLine("*** Controle de Estoque ***");
        Console.WriteLine("");


        // instanciando a classe Estoque

        Estoque estoque1 = new Estoque();

        // loop para o menu de opções

        while (true)
        {

            string name;
            int amount;
            double price;

            Console.WriteLine("Escolha uma opção:\n1) Inserir Produto\n2) Listar Produto\n3) Sair");
            Console.WriteLine("");
            escolha = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            // opção para inserir os produtos

            if (escolha == 1)
            {
                Console.WriteLine("Insira o nome do produto");
                name = Console.ReadLine();

                Console.WriteLine("");

                Console.WriteLine("Insira a quantidade do produto");
                amount = int.Parse(Console.ReadLine());

                Console.WriteLine("");

                Console.WriteLine("Insira o preço do produto");
                price = double.Parse(Console.ReadLine());

                estoque1.Inserir_Produto(name, amount, price);


            }

            // opção para listar os produtos

            else if (escolha == 2)
            {

                Console.WriteLine("Lista dos produtos");
                Console.WriteLine("");
                estoque1.Listar_Produto();
                estoque1.Criar_txt();
            }

            // opção para sair do programa
            else if (escolha == 3)
            {
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
