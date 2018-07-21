using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Brainsman.Models
{
    public class Cliente
    {
        [Required(ErrorMessage="Nome obrigatório")]
        [StringLength(50, MinimumLength =3,ErrorMessage ="O nome deve ter, no  mínimo 3 letras.")]
        [Display(Name="Nome:")]
        public string nome { get; set; }
        [Required(ErrorMessage = "Idade obrigatória.")]
        [StringLength(3, MinimumLength = 1, ErrorMessage = "Idade incorreta!")]
        [Display(Name = "Idade:")]
        public int idade { get; set; }
        [Required(ErrorMessage = "CPF obrigatório")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "CPF inválido.")]
        [Display(Name = "CPF:")]
        public string cpf { get; set; }
        [StringLength(50, MinimumLength = 3, ErrorMessage = "O apelido deve ter, no  mínimo 3 letras.")]
        [Display(Name = "Apelido:")]
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