using Backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Backend.Data
{
    public class ComandaDbContext : DbContext
    {
        public ComandaDbContext(DbContextOptions<ComandaDbContext> options) : base(options){ }
        public DbSet<Usuarios> Usuarios { get; set; }  
    }
}
