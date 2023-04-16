namespace Backend.Models
{
    public class Vendas
    {
        public int IdVenda { get; set; }
        public DateTime TempoVenda { get; set; }
        public string StatusVenda { get; set; }
        public DateTime DataVenda { get; set; }
        public Double Preco { get; set; }
        public char TipoVenda { get; set; }
        public int IdCliente { get; set; }
        public int IdEntrega { get; set; }
        public int IdCarrinho { get; set; }
    }
}
