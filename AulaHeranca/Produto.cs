using System;
using System.Collections.Generic;
using System.Text;

namespace AulaHeranca
{
    class Produto
    {
        // atributos
        private string nome;
        private double valor;

        public Produto(string nome, double valor) {
            this.Nome = nome;
            this.Valor = valor;
        }

        public double Valor { get => valor; set => valor = value; }
        public string Nome { get => nome; set => nome = value; }
    }
}
