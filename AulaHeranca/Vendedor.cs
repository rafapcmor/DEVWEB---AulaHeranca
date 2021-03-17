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
    }
}
