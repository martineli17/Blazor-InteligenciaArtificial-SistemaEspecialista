using Crosscuting.Notificacao;
using Dominio.Entidades;
using Dominio.Interfaces.Repositorio;
using Microsoft.EntityFrameworkCore;
using Repositorio.Contexto;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Repositorio.Repositorios
{
    public class VariavelRepositorio : BaseRepositorio<Variavel>, IVariavelRepositorio
    {
        public VariavelRepositorio(Context context, INotificador notificador) : base(context, notificador)
        {
        }

        public Task<IQueryable<Variavel>> GetWithIncludesAsync(Expression<Func<Variavel,bool>> filter = null)
        {
            var query = Context.Variavel.AsQueryable();
            if (filter != null)
                return Task.FromResult(Context.Variavel.Where(filter).Include(x => x.Valores).Include(x => x.RegrasVariavel).AsQueryable());
            else
                return Task.FromResult(Context.Variavel.Include(x => x.Valores).Include(x => x.RegrasVariavel).AsQueryable());
        }
    }
}
