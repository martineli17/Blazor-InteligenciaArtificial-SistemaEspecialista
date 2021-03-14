using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositorio.Mapeamento
{
    public class VariavelMapping : IEntityTypeConfiguration<Variavel>
    {
        public void Configure(EntityTypeBuilder<Variavel> builder)
        {
            builder.ToTable("VARIAVEL");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).HasColumnName("NOME").HasColumnType("VARCHAR(50)").IsRequired().HasMaxLength(50);
            builder.Property(x => x.Pergunta).HasColumnName("PERGUNTA").HasColumnType("TEXT").IsRequired();
            builder.Property(x => x.MotivoPergunta).HasColumnName("MOTIVOPERGUNTA").HasColumnType("TEXT").IsRequired();
            builder.Property(x => x.Nome).HasColumnName("NOME").HasColumnType("VARCHAR(50)").IsRequired().HasMaxLength(50);
            builder.Property(x => x.Objetivo).HasColumnName("OBJETIVO").HasColumnType("BIT");
            builder.HasMany(x => x.Valores).WithOne(x => x.Variavel).HasForeignKey(x => x.IdVariavel);
        }
    }
}
