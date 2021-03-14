using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositorio.Mapeamento
{
    public class RegraVariavelMapping : IEntityTypeConfiguration<RegraVariavel>
    {
        public void Configure(EntityTypeBuilder<RegraVariavel> builder)
        {
            builder.ToTable("REGRAVARIAVEL");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.ValorVariavel).HasColumnName("VALORVARIAVEL").HasColumnType("VARCHAR(250)").IsRequired().HasMaxLength(250);
            builder.Property(x => x.IdVariavel).HasColumnName("IDVARIAVEL").HasColumnType("UNIQUEIDENTIFIER").IsRequired();
            builder.Property(x => x.Complemento).HasColumnName("COMPLEMENTO").HasColumnType("BIT");
            builder.HasOne(x => x.Regra).WithMany(x => x.RegrasVariavel).HasForeignKey(x => x.IdRegra);
            builder.HasOne(x => x.Variavel).WithMany(x => x.RegrasVariavel).HasForeignKey(x => x.IdVariavel);
        }
    }
}
