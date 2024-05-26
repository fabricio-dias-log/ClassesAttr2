using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAttr2
{
    internal class Produto
    {
        public string Nome;
        public double Valor;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Quantidade * Valor;
        }

        public override string ToString()
        {
            return $"Nome: {Nome} | Preço: R${Valor.ToString("F2")} | Estoque: {Quantidade} | Total R$: R${ValorTotalEmEstoque().ToString("F2")}";
        }

        public void AdicionarProdutos(int quantity)
        {
            Quantidade += quantity;
            ToString();
        }

        public void RemoverProdutos(int quantity)
        {
            Quantidade -= quantity;
            ToString();
        }
    }
}
