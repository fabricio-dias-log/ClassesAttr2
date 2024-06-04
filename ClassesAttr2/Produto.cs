﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAttr2
{
    internal class Produto
    {
        private string _nome;
        private double _valor;
        private int _quantidade;

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
            _valor = valor;
        }

        public Produto(string nome, double valor, int quantidade) : this(nome,valor)
        {
            _quantidade = quantidade;
        }

        public double Valor
        {
            get { return _valor; }
        }

        public int Quantidade
        {
            get { return _quantidade; }
        }

        public double ValorTotalEmEstoque()
        {
            return _quantidade * _valor;
        }

        public override string ToString()
        {
            return $"Nome: {_nome} | Preço: R${_valor.ToString("F2")} | Estoque: {_quantidade} | Total R$: R${ValorTotalEmEstoque().ToString("F2")}";
        }

        public void AdicionarProdutos(int quantity)
        {
            _quantidade += quantity;
            ToString();
        }

        public void RemoverProdutos(int quantity)
        {
            _quantidade -= quantity;
            ToString();
        }
    }
}
