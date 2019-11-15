using Microsoft.EntityFrameworkCore;
using restaurante.domain.Entities;

namespace restaurante.repository.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Restaurante> restaurantes { get; set; }
        public DbSet<Consumo> consumos { get; set; }
    }
    
}