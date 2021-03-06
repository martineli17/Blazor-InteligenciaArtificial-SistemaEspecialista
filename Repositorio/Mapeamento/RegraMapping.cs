using Dominio.Entidades;
using Dominio.ValuesType;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Repositorio.Mapeamento
{
    public class RegraMapping : IEntityTypeConfiguration<Regra>
    {
        public void Configure(EntityTypeBuilder<Regra> builder)
        {
            builder.ToTable("REGRA");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.IdProjeto).HasColumnName("IDPROJETO").HasColumnType("UNIQUEIDENTIFIER").IsRequired();
            builder.Property(x => x.IdVariavelObjetivo).HasColumnName("IDVARIAVELOBJETIVO").HasColumnType("UNIQUEIDENTIFIER").IsRequired();
            builder.Property(x => x.Complemento).HasColumnName("COMPLEMENTO").HasColumnType("VARCHAR(5)")
                                                                             .HasConversion(v => v.ToString(),
                                                                              v => (EnumTipoComplemento)Enum.Parse(typeof(EnumTipoComplemento), v));
            builder.Property(x => x.ValorVariavelObjetivo).HasColumnName("VALORVARIAVELOBJETIVO").HasColumnType("VARCHAR(250)").IsRequired().HasMaxLength(250);
            builder.HasOne(x => x.VariavelObjetivo).WithMany(x => x.Regras).HasForeignKey(x => x.IdVariavelObjetivo);
        }
    }
}
