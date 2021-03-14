using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositorio.Mapeamento
{
    public class ProjetoMapping : IEntityTypeConfiguration<Projeto>
    {
        public void Configure(EntityTypeBuilder<Projeto> builder)
        {
            builder.ToTable("PROJETO");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).HasColumnName("NOME").HasColumnType("VARCHAR(50)").IsRequired().HasMaxLength(50);
            builder.Property(x => x.Descricao).HasColumnName("DESCRICAO").HasColumnType("VARCHAR(250)").HasMaxLength(250);
            builder.Property(x => x.Autor).HasColumnName("AUTOR").HasColumnType("VARCHAR(50)").HasMaxLength(50);
        }
    }
}
