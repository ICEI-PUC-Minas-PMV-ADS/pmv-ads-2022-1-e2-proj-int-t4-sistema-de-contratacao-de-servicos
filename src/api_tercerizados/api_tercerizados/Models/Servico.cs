using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_tercerizados.Models
{   
    [Table("servico")]
    public class Servico
    {   
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o Nome do Serviço!")]
        public string NomeServico { get; set; }
        
        [Required(ErrorMessage = "Obrigatório Informar a Descrição do Serviço!")]
        public string DescricaoServico { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o Orçamento!")]
        public string Orcamento { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o Valor Estimado do Serviço!")]
        public string ValorEstimadoServico { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar a Data da Aprovaçã do Orçamento!")]
        public string DataAprovacaoOrcamento { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar a Data da Conclusão do Serviço!")]
        public string DataConclusaoDoServico { get; set; }
        }
}
