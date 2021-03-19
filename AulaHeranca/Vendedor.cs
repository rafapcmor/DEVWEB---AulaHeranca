using System;
using System.Collections.Generic;
using System.Text;

namespace AulaHeranca
{
    class Vendedor: Funcionario
    {
        private List<Venda> listaVendas;
        
        public Vendedor(string nome, int idade, char sexo, long cpf, double salario, int matricula): base(nome,idade,sexo, cpf, salario, matricula) {
            ListaVendas = new List<Venda>();
        }

        internal List<Venda> ListaVendas { get => listaVendas; set => listaVendas = value; }

        public double ObterTotalVendas() {
            double total = 0;

            foreach (Venda v in listaVendas) {
                total += v.ObterValorVenda();
            }
            return total;
        }

        public override string ToString()
        {
            string vendas, texto1, texto2;
            texto1 = base.ToString();
            vendas = "\nVendas:\n";
            foreach (Venda v in ListaVendas)
            {
                vendas += v.ToString();
            }

            texto2 = "\nValor Total das Vendas de " + base.Nome + " é R$ " + ObterTotalVendas().ToString("C") + ": " + "\n";
            return texto1 + vendas + texto2;

        }
    }
}
