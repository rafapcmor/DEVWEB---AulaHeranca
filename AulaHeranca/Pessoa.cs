using System;
using System.Collections.Generic;
using System.Text;

namespace AulaHeranca
{
    class Pessoa
    {
        //atributos
        private string nome;
        private int idade;
        private char sexo;
        private long cpf;

        // construtor

        public Pessoa() { }
        public Pessoa(string nome, int idade, char sexo, long cpf)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Sexo = sexo;
            this.Cpf = cpf;
        }

        // metodos getter e setter
        public string Nome { get => nome; set => nome = value; }
        public int Idade { get => idade; set => idade = value; }
        public char Sexo { get => sexo; set => sexo = value; }
        public long Cpf { get => cpf; set => cpf = value; }






    }
}
