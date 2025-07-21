using CatFinanças.Domain.Entidades;
using CatFinanças.Infra.Maps;
using Microsoft.EntityFrameworkCore;

namespace CatFinanças.Infra.Persistencia
{
    public class CatFinancasContext : DbContext
    {
        public CatFinancasContext(DbContextOptions<CatFinancasContext> options) : base(options) { }

        public DbSet<Gasto> Gasto { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new GastoMap());

            //modelBuilder.HasDefaultSchema("CatFinancas");
        }
    }
}
