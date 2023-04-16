namespace Backend.Models
{
    public class CarrinhoProduto
    {
        public int IdCarrinho { get; set; }
        public int IdProduto { get; set; }
        public int QuantidadePC { get; set; }
        public string Sabores { get; set; }
    }
}
