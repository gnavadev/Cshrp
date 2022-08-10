using System;
using System.Globalization;


namespace Estoque
{
    class Program
    {
        static void Main(string[] args)
        {

            EstoqueCalculo produto;
            produto = new EstoqueCalculo();



            System.Console.WriteLine("Digite os dados do produto: ");
            System.Console.Write("Nome: ");
            produto.nome = Console.ReadLine();
            System.Console.Write("Preco: ");
            produto.preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            System.Console.Write("Quantidade: ");
            produto.quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double total = produto.ValorTotalEmEstoque();

            System.Console.WriteLine($"Dados do Produto: " + produto);


            System.Console.WriteLine("Voce Gostaria de adicionar ou remover um produto? (1 ADD, 2REMOVE): ");
            int opcao = int.Parse(Console.ReadLine());
            if (opcao == 1)
            {
                System.Console.WriteLine("Digite o numero de produtos a ser adicionado: ");
                int adicionado = int.Parse(Console.ReadLine());
                produto.AdicionarProdutos(adicionado);
                System.Console.WriteLine($"Dados Atualizados: " + produto);

            }
            else if (opcao == 2)
            {

                System.Console.WriteLine("Digite o numero de produtos a ser removido: ");
                int removido = int.Parse(Console.ReadLine());
                produto.RemoverProdutos(removido);
                System.Console.WriteLine($"Dados Atualizados: " + produto);


            }
            else
            {
                System.Console.WriteLine("Opcao Ivalida!");
            }



        }
    }
}