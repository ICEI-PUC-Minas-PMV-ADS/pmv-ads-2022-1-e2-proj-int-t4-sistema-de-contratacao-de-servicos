﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_contratos_servicos.Models
{
    [Table("usuarios")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o nome!")]
        public string Nome { get; set; }

        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "Obrigatório Informar o e-mail!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar a senha!")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar a senha!")]
        public string Role { get; set; }

        public Usuario(string Nome, string Email,String Senha, String Role)
        {
            this.Senha = Senha;
            this.Nome = Nome;
            this.Email = Email;
            this.Role = Role;
        }

        public Usuario()
        {
        }



    }

}
