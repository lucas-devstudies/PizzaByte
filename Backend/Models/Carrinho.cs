using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public class Carrinho
    {
        [Key]
     public int IdCarrinho { get; set; }
     public string Observacao { get; set; }

    }
}
