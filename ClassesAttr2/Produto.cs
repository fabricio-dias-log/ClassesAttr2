using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAttr2
{
    internal class Produto
    {
        private string _nome; //possui lógica própria
        public double Valor { get; private set; }
        public int Quantidade { get; private set; }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public Produto()
        {
        }
        
        public Produto(string nome, double valor) : this()
        {
            _nome = nome;
            Valor = valor;
        }

        public Produto(string nome, double valor, int quantidade) : this(nome,valor)
        {
            Quantidade = quantidade;
        }

        public double ValorTotalEmEstoque()
        {
            return Quantidade * Valor;
        }

        public override string ToString()
        {
            return $"Nome: {_nome} | Preço: R${Valor.ToString("F2")} | Estoque: {Quantidade} | Total R$: R${ValorTotalEmEstoque().ToString("F2")}";
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
