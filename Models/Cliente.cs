using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Brainsman.Models
{
    public class Cliente
    {
        public string nome { get; set; }
        public int idade { get; set; }
        public string cpf { get; set; }
        public string apelido { get; set; }
        public string email { get; set; }
        public string senha { get; set; }

        public Cliente()
        {

        } 
        public Cliente(string nome, int idade, string cpf, string apelido, string email, string senha)
        {
            this.nome = nome;
            this.idade = idade;
            this.cpf = cpf;
            this.apelido = apelido;
            this.email = email;
            this.senha = senha;
        }
    }
}