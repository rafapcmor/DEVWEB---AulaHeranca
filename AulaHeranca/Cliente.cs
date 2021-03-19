using System;
using System.Collections.Generic;
using System.Text;

namespace AulaHeranca
{
    class Cliente:Pessoa
    {
        private string tipoCliente;

        public Cliente(string nome, int idade, char sexo, long cpf, string tipoCliente): base(nome,idade,sexo,cpf) {
            this.tipoCliente = tipoCliente;
        }

        public string TipoCliente { get => tipoCliente; set => tipoCliente = value; }

        public override string ToString()
        {
            return base.ToString() + "Tipo Cliente: " + TipoCliente;
        }

    }
}
