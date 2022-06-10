using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_terceirizados.Models
{
    [Table("Usuarios")]
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

        public Usuario(string Nome, string Email, String Senha)
        {
            this.Senha = Senha;
            this.Nome = Nome;
            this.Email = Email;
        }

        public Usuario()
        {
        }
    }
}
