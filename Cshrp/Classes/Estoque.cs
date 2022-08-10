using System;
using System.Globalization;

namespace Estoque
{
    class EstoqueCalculo
    {
        public string nome;

        public double preco;

        public int quantidade;


        public double ValorTotalEmEstoque()
        {
            return preco * quantidade;
        }

        public override string ToString()
        {
            return nome
            + ", R$ "
            + preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + quantidade
            + "unidades, Total: R$"
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

        public void AdicionarProdutos(int quantity)
        {
            quantidade += quantity;
        }

        public void RemoverProdutos(int quantity)
        {
            quantidade -= quantity;
        }

    }
}
