using System.Globalization;

namespace ClassesAttr2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option;
            int qtd;

            Console.WriteLine("Insira os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());
            
            Produto produto = new Produto(nome, valor, quantidade);

            do
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine("Digite a opção desejada:");
                Console.WriteLine("1 - Detalhes do produto");
                Console.WriteLine("2 - Adicionar produto");
                Console.WriteLine("3 - Remover produto");
                Console.WriteLine("-----------------------------");
                Console.Write("Opção: ");

                option = int.Parse(Console.ReadLine());

                Console.Clear();

                switch (option)
                {
                    case 1:
                        Console.WriteLine($"Dados do produto -> {produto}");

                        break;
                    case 2:
                        Console.Write("Digite a quantidade desejada: ");

                        qtd = int.Parse(Console.ReadLine());
                        produto.AdicionarProdutos(qtd);

                        break;
                    case 3:
                        Console.Write("Digite a quantidade desejada: ");

                        qtd = int.Parse(Console.ReadLine());
                        produto.RemoverProdutos(qtd);

                        break;
                    default:
                        return;
                }

            } while (option != 0);
        }
    }
}
