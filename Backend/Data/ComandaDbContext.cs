using Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend.Data

{
    public class ComandaDbContext : DbContext
    {
        public ComandaDbContext(DbContextOptions<ComandaDbContext> options) : base(options) { }

        public DbSet<Entrega> Entrega { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; } 
        public DbSet<Entregadores> Entregadores { get; set; }
        public DbSet<Carrinho> Carrinho { get; set; }
        public DbSet<CarrinhoProduto> CarrinhoProduto { get; set; }
    }
}
