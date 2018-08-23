using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Brainsman.Models
{
    [Table("CLIENTE")]
    public class Cliente
    {
<<<<<<< HEAD
    
        [Key]
        [Coloumn(Name = "COD")]
        public int cod {get; set;}
        
        [Required(ErrorMessage="Nome obrigatório")]
        [StringLength(50, MinimumLength =3,ErrorMessage ="O nome deve ter, no  mínimo 3 letras.")]
        [Display(Name="Nome:")]
=======
        //Atributos da classe Cliente
>>>>>>> 5eb4f68df10de74b4cf0b6bab7121d6e3d61943e
        public string nome { get; set; }
        [Coloumn ("IDADE")]
        [Required(ErrorMessage = "Idade obrigatória.")]
        [StringLength(3, MinimumLength = 1, ErrorMessage = "Idade incorreta!")]
        [Display(Name = "Idade:")]
        public int idade { get; set; }
        [Coloumn ("CPF")]
        [Required(ErrorMessage = "CPF obrigatório")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "CPF inválido.")]
        [Display(Name = "CPF:")]
        public string cpf { get; set; }
        [Coloumn ("APELIDO")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "O apelido deve ter, no  mínimo 3 letras.")]
        [Display(Name = "Apelido:")]
        public string apelido { get; set; }
        [Coloumn ("EMAIL")]
        [Display (Name = "Email")]
        public string email { get; set; }
        public string senha { get; set; }
        //Construtor padrão
        public Cliente()
        {

        } 
        //Construtor de classe
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
