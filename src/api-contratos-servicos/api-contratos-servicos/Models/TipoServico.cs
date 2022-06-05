using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_contratos_servicos.Models
{
    [Table("tipo servico")]
    public class TipoServico
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o Nome do Serviço")]
        public string NomeServico { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar a Descrição do Serviço")]
        public string DescricaoServico { get; set; }

    }
}
