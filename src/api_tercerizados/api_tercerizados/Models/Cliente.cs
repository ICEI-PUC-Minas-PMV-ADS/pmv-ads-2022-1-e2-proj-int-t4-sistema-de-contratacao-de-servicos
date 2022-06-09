using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_terceirizados.Models
{
    [Table("Clientes")]
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o CPF!")]
        public string cpf { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o telefone!")]
        public string Telefone { get; set; }
         
        [Required(ErrorMessage = "Obrigatório Informar o logradouro!")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o bairro!")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o numero!")]
        public string Numero { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar a Cidade!")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar a UF!")]
        public string UF { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o CEP!")]
        public string CEP { get; set; }

        public int UsuarioId { get; set; }
        /*
        [ForeignKey("UsuarioId")]
        public Usuario Usuario { get; set; }*/
    }
}
