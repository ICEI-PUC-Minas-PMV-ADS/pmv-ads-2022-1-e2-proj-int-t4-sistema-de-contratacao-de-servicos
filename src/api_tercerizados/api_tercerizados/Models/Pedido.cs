using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_terceirizados.Models
{
    [Table("Pedidos")]
    public class Pedido
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o Cliente!")]
        public string Cliente { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o Tipo De Serviço!")]
        public string TipoServiço { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar a Data!")]
        LocalDataStoreSlot  Data { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar a Descrição!")]
        public string Descrição { get; set; }

      
        public int UsuarioId { get; set; }
        /*
        [ForeignKey("UsuarioId")]
        public Usuario Usuario { get; set; }*/
    }
}
