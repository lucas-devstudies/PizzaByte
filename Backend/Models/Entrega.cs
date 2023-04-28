using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public class Entrega
    {
		[Key]
	public int IdEntrega { get; set; }
	public String NomeMotoboy { get; set; }
	public String VeiculoMotoboy { get; set; }
	public String TelefoneMotoboy { get; set; }
	public decimal ValorEntrega { get; set; }
	public decimal ValorMotoboy { get; set; }



        
    }
}
