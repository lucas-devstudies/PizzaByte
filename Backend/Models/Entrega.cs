using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{
    public class Entrega
    {
		[Key]
	public int IdEntrega { get; set; }
        
		[ForeignKey ("IdEntregador")]
    public int IdEntregador { get; set; }
	
	public decimal ValorEntrega { get; set; }

	public string StatusEntrega { get; set; } // VER

	public DateTime DataEntrega { get; set; }
	

    }
}
