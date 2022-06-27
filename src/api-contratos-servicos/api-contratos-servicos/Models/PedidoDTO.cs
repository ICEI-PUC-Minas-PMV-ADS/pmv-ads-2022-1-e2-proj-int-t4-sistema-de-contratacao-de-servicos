using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_contratos_servicos.Models
{
    public class PedidoDTO { 

        public string tipoServico { get; set; }
        public DateTime data { get; set; }
        public string descricao { get; set; }
        public string status { get; set; }
        public int idPedido { get; set; }
        public int idUduario { get; set; }
        public string cliente { get; set; }
        public int idCliente { get; set; }

    }
}
