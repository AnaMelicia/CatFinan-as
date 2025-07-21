using CatFinanças.Infra.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

public class CatFinancasContextFactory : IDesignTimeDbContextFactory<CatFinancasContext>
{
    public CatFinancasContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<CatFinancasContext>();

        //TODO Coloque sua connection string aqui (a mesma que usa em Program.cs)
        var connectionString = "server=localhost;database=CatFinancasDb;user=root;password=admin";

        optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));

        return new CatFinancasContext(optionsBuilder.Options);
    }
}
