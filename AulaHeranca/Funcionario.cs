using System;
using System.Collections.Generic;
using System.Text;

namespace AulaHeranca
{
    class Funcionario: Pessoa
    {
        private double salario;
        private double matricula;

        public Funcionario(string nome, int idade, char sexo, long cpf, double salario, int matricula): base(nome, idade, sexo, cpf){
            this.Salario = salario;
            this.Matricula = matricula;
        }

        public double Matricula { get => matricula; set => matricula = value; }
        public double Salario { get => salario; set => salario = value; }
    }
}
