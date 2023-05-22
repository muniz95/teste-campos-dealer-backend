namespace TesteCamposDealerBackend.Models
{
    public class Cliente
    {
        public int idCliente { get; set; }

        public string nmCliente { get; set; }

        public string Cidade { get; set; }

        public ICollection<Venda>? vendas { get; set; }
    }
}
