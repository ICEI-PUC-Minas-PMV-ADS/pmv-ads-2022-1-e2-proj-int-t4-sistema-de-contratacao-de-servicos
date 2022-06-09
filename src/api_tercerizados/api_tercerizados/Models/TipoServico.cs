using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_terceirizados.Models
{
    [Table("TipoServico")]
    public class TipoServico
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar a Descricao do Tipo de Serviço!")]
        public string descricaoServico { get; set; }

    }
}
