using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public class Entregadores
    {
        [Key]
     public int IdEntregador { get; set; }
     public string NomeEntregador { get; set; }
    public string VeiculoEntregador { get; set; }
    public string TelefoneEntregador {get; set; }

    }
}
