using CatFinanças.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CatFinanças.Infra.Maps;

public sealed class GastoMap : IEntityTypeConfiguration<Gasto>
{
    public void Configure(EntityTypeBuilder<Gasto> builder)
    {
        //builder.ToTable(nameof(Gasto));
        builder.HasKey(x => x.Id);
        builder.Property(gasto => gasto.Name).HasMaxLength(100);
    }
}