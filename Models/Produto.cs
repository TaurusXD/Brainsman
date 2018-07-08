using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Brainsman.Models
{
    public class Produto
    {
        public string nome { get; set; }
        public int quantidade { get; set; }
        public string  tipo { get; set; }
        public string desc { get; set; }

        public Produto()
        {

        }

        public Produto(string nome, int quantidade, string tipo, string desc)
        {
            this.nome = nome;
            this.quantidade = quantidade;
            this.tipo = tipo;
            this.desc = desc;
        }
    }
}