using baseproyecto.Shared.Modelos;
using Microsoft.EntityFrameworkCore;

namespace baseproyecto.Server.Data
{
    public class Base_datos : DbContext
    {
        public Base_datos(DbContextOptions<Base_datos> options):base(options)
        {
        }
        public DbSet<Alimentos> alimentos { get; set; }
        public DbSet<Entrada> Entrada { get; set; }
        public DbSet<Pedidos> Pedidos { get; set; }
    }
}
