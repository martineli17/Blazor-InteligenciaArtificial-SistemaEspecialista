using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Repositorio.Contexto
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet<Variavel> Variavel { get; set; }
        public DbSet<ValoresVariavel> ValoresVariavel { get; set; }
        public DbSet<Projeto> Projeto { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(GetType().Assembly);
            base.OnModelCreating(builder);
        }
    }
}