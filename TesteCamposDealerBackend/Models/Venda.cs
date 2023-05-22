using System.ComponentModel.DataAnnotations.Schema;

namespace TesteCamposDealerBackend.Models
{
    public class Venda
    {
        public int idVenda { get; set; }
        public int idCliente { get; set; }
        
        [ForeignKey("idCliente")]
        public Cliente Cliente { get; set; }
        
        [ForeignKey("idProduto")]
        public int idProduto { get; set; }
        public Produto Produto { get; set; }
        public int qtdVenda { get; set; }
        public float vlrUnitarioVenda { get; set; }
        public DateTime dthVenda { get; set; }
        public float vlrTotalVenda { get; set; }
    }
}
