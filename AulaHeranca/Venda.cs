using System;
using System.Collections.Generic;
using System.Text;

namespace AulaHeranca
{
    class Venda
    {
        private Produto produtoVendido;
        private Cliente comprador;
        private int quantidadeVendida;

        public Venda(Produto p, Cliente c, int quant) {
            this.ProdutoVendido = p;
            this.Comprador = c;
            this.QuantidadeVendida = quant;     
        }

        public int QuantidadeVendida { get => quantidadeVendida; set => quantidadeVendida = value; }
        internal Produto ProdutoVendido { get => produtoVendido; set => produtoVendido = value; }
        internal Cliente Comprador { get => comprador; set => comprador = value; }

        public double ObterValorVenda() {

            return produtoVendido.Valor * quantidadeVendida;
        }

        public override string ToString()
        {
            return "--------Venda--------" +
           "\nProduto: " + ProdutoVendido.ToString() +
           "\nCliente: " + Comprador.ToString() +
           "\nQuantidade Vendida: " + QuantidadeVendida +
           "\nValor da Venda R$ " + ObterValorVenda().ToString("C") + ": " +
           "\n";
        }
    }
}
