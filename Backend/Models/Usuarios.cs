using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public class Usuarios
    {
        [Key]
        public int idCliente  { get; set; }  
        public char tipoCliente { get; set; }   
        public string nomeCliente { get; set; }
        public string telefoneCliente { get; set; } 
    }
}

