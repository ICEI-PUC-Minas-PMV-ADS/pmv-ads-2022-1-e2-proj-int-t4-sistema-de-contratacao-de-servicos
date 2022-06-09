using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_tercerizados.Models
{
    [Table("Orçamento")]
    public class Orcamento
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o Número do Pedido!")]
        public string Pedido { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o Valor do Orçamento!")]
        public string ValorOrcamento { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o Fornecedor!")]
        public string Fornecedor { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o Status da Aprovação!")]
        public string orcamentoAprovado { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar a Data!")]
        public string Data { get; set; }
    }
}
