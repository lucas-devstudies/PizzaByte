using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{
    public class CarrinhoProduto
    {

        [Key]

        [ForeignKey("IdCarrinho")]
        public int IdCarrinho { get; set; }

        [ForeignKey("IdProduto")]
        public int IdProduto { get; set; }

        public int QuantidadePC { get; set; }
        public string Sabores { get; set; } 

    }
}
