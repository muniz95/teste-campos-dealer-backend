namespace TesteCamposDealerBackend.Models
{
    public class Produto
    {
        public int idProduto { get; set; }
        public string dscProduto { get; set; }
        public float vlrUnitario { get; set; }
        public ICollection<Venda>? vendas { get; set; }
    }
}
