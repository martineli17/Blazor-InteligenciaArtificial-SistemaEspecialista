using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositorio.Mapeamento
{
    public class ValoresVariavelMapping : IEntityTypeConfiguration<ValoresVariavel>
    {
        public void Configure(EntityTypeBuilder<ValoresVariavel> builder)
        {
            builder.ToTable("VALORESVARIAVEL");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Valor).HasColumnName("VALOR").HasColumnType("VARCHAR(250)").IsRequired().HasMaxLength(250);
            builder.HasOne(x => x.Variavel).WithMany(x => x.Valores).HasForeignKey(x => x.IdVariavel);
        }
    }
}
