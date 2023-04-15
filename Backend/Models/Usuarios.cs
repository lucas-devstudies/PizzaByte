using Microsoft.AspNetCore.Http.HttpResults;
using System.Security.Principal;

namespace Backend.Models
{
    public class Usuarios
    {
        public int IdCliente { get; set; }
        public char TipoCliente { get; set; }
	    public string NomeCliente { get; set; }
	    public string TelefoneCliente { get; set; }
    }
}
